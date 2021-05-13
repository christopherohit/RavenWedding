using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Drawing;
using BookShelf.Properties;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

namespace BookShelf
{
    public class BookShelfApp
    {
        #region Resources

        #region Fonts

        public static Font SegoeUI10 = new Font("Segoe UI", 10.5f);
        public static Font SegoeUI12 = new Font("Segoe UI", 12);
        public static Font SegoeUI22Bold = new Font("Segoe UI", 22, FontStyle.Bold);
        public static Font SegoeUI25Light = new Font("Segoe UI Light", 25);
        public static Font SegoeUI35Light = new Font("Segoe UI Light", 35);
        public static Font SegoeUI25Bold = new Font("Segoe UI", 25, FontStyle.Bold);

        #endregion

        #region Bitmaps

        public static Bitmap search_btn_selected = Resources.search_btn_selected;
        public static Bitmap search_btn = Resources.search_btn;
        public static Bitmap logo_sign_nonfiction = Resources.logo_sign_nonfiction;
        public static Bitmap logo_sign_fiction = Resources.logo_sign_fiction;
        public static Bitmap logo_sign_textbooks = Resources.logo_sign_textbooks;
        public static Bitmap logo_sign_children = Resources.logo_sign_children;
        public static Bitmap logo_sign_magazine = Resources.logo_sign_magazine;
        public static Bitmap logo_sign_antiquarian = Resources.logo_sign_antiquarian;
        public static Bitmap logo_sign_audiobooks = Resources.logo_sign_audiobooks;
        public static Bitmap logo_sign_cookbooks = Resources.logo_sign_cookbooks;
        public static Bitmap logo_sign_other = Resources.logo_sign_other;
        public static Bitmap logo_sign_home = Resources.logo_sign_home;
        public static Bitmap bg_pattern = Resources.bg_pattern;
        public static Bitmap app_bar_bg = Resources.app_bar_bg;

        #endregion

        #endregion

        #region Fields

        Dictionary<string, Category> categories = new Dictionary<string, Category>();
        Dictionary<string, Book> books = new Dictionary<string, Book>();
        List<Book> popular = new List<Book>();
        List<Book> latest = new List<Book>();
        Category currentCategory;
        Book currentBook;
        bool isLoaded;
        int loadingImages;
        bool suppressHistory;
        HistoryItem currentHistoryItem;

        Dictionary<PageID, IBookShelfPage> pages = new Dictionary<PageID, IBookShelfPage>();
        PageID currentPageID = PageID.NotInitialized;
        Stack<HistoryItem> history = new Stack<HistoryItem>();
        MainForm form;

        static BookShelfApp instance;

        #endregion

        #region Initialization

        public BookShelfApp()
        {
            IBookShelfPage page = new AllCategoriesPage();
            pages.Add(page.PageID, page);

            page = new AllCategoriesZoomOutPage();
            pages.Add(page.PageID, page);

            page = new CategoryZoomOutPage();
            pages.Add(page.PageID, page);

            page = new DetailsViewPage();
            pages.Add(page.PageID, page);

            page = new MainPage();
            pages.Add(page.PageID, page);

            page = new SearchPage();
            pages.Add(page.PageID, page);

            page = new SingleCategoryPage();
            pages.Add(page.PageID, page);
        }

        #endregion

        #region Properties

        public static BookShelfApp Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookShelfApp();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public string FileName
        {
            get
            {
                string fullPath = this.GetApplicationDataFolder();                
                return Path.Combine(fullPath, Settings.Default.CacheFileName);
            }
        }

        public string BackUpFileName
        {
            get
            {
                string fullPath = this.GetApplicationDataFolder();
                return Path.Combine(fullPath, Settings.Default.BackUpFileName);
            }
        }

        private string GetApplicationDataFolder()
        {
            string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPath = roamingPath + @"\Telerik\WinForms\Examples\BookShelf";
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }

            return fullPath;
        }

        public string LocalBackupFileName
        {
            get { return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), Settings.Default.BackUpFileName); }
        }

        public Dictionary<string, Category> Categories
        {
            get { return categories; }
        }

        public Dictionary<string, Book> Books
        {
            get
            {
                return books;
            }
        }

        public List<Book> Popular
        {
            get
            {
                return popular;
            }
        }

        public List<Book> Latest
        {
            get
            {
                return latest;
            }
        }

        public MainForm Form
        {
            get { return form; }
            set { form = value; }
        }

        public Dictionary<PageID, IBookShelfPage> Pages
        {
            get { return pages; }
        }

        public IBookShelfPage CurrentPage
        {
            get
            {
                return pages[currentPageID];
            }
        }

        public PageID CurrentPageID
        {
            get { return currentPageID; }
            set
            {
                if (currentPageID != value || CurrentPage.ShouldUpdate())
                {
                    if (currentHistoryItem != null && !suppressHistory)
                    {
                        currentHistoryItem.searchText = BookShelfApp.Instance.Form.SearchTextBox.Text;
                        currentHistoryItem.scrollValue = BookShelfApp.Instance.Form.Panorama.PanoramaElement.ScrollBar.Value;
                        History.Push(currentHistoryItem);
                    }
                    currentPageID = value;
                    pages[currentPageID].SetupPage(form);
                    currentHistoryItem = new HistoryItem();
                    if (CurrentPageID == PageID.Main)
                    {
                        History.Clear();
                    }
                }
            }
        }

        public Category CurrentCategory
        {
            get
            {
                return currentCategory;
            }
            set
            {
                currentCategory = value;
            }
        }

        public Book CurrentBook
        {
            get
            {
                return currentBook;
            }
            set
            {
                currentBook = value;
                if (value != null)
                {
                    CurrentCategory = currentBook.Category;
                }
            }
        }

        public Stack<HistoryItem> History
        {
            get { return history; }
        }

        public bool IsLoaded
        {
            get
            {
                return isLoaded;
            }
        }

        internal int LoadingImages
        {
            get
            {
                return loadingImages;
            }
            set
            {
                loadingImages = value;
                if (value == 0)
                {
                    OnImagesLoaded(true);
                }
            }
        }

        #endregion

        #region Events

        public EventHandler CategoryListLoaded;
        public EventHandler CategoryLoaded;
        public EventHandler LoadComplete;
        public EventHandler ImagesLoaded;

        #endregion

        #region Methods

        public void LoadData()
        {
            ThreadPool.QueueUserWorkItem(LoadDataWorkItem);
        }

        public Color GetColor(string category)
        {
            switch (category)
            {
                case "Nonfiction":
                    return Color.FromArgb(228, 255, 80);
                case "Fiction & Literature":
                    return Color.FromArgb(255, 228, 0);
                case "Textbooks, Education":
                    return Color.FromArgb(127, 255, 202);
                case "Children Young Adults":
                    return Color.FromArgb(134, 219, 97);
                case "Magazine Back Issues":
                    return Color.FromArgb(254, 205, 250);
                case "Antiquarian & Collectible":
                    return Color.FromArgb(255, 165, 119);
                case "Audiobooks":
                    return Color.FromArgb(169, 137, 255);
                case "Cookbooks":
                    return Color.FromArgb(190, 255, 127);
                case "Other":
                    return Color.FromArgb(168, 232, 244);
                default:
                    return Color.White;
            }
        }

        public void GoBack()
        {
            if (History.Count == 0)
            {
                return;
            }
            suppressHistory = true;
            History.Pop().Apply();
            suppressHistory = false;
        }

        #endregion

        #region Event handlers

        void LoadDataWorkItem(object threadContext)
        {
            if (!DeserializeData(FileName))
            {
                try
                {
                    int maxBooksCount = 10;

                    AddCategory("Nonfiction", maxBooksCount, 378);
                    AddCategory("Fiction & Literature", maxBooksCount, 377);
                    AddCategory("Textbooks, Education", maxBooksCount, 2228);
                    AddCategory("Children Young Adults", maxBooksCount, 279);
                    AddCategory("Magazine Back Issues", maxBooksCount, 280);
                    AddCategory("Antiquarian & Collectible", maxBooksCount, 29223);
                    AddCategory("Audio books", maxBooksCount, 29792);
                    AddCategory("Cookbooks", maxBooksCount, 11104);
                    AddCategory("Other", maxBooksCount, 268);

                    OnCategoryListLoaded();
                    OnLoadComplete();
                }
                catch
                {
                    MessageBox.Show("Service is temporary unavailable. Outdated data will be loaded.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DeserializeData(LocalBackupFileName);
                }

            }
        }

        void OnCategoryListLoaded()
        {
            EventHandler handler = CategoryListLoaded;
            if (handler != null)
            {
                CategoryListLoaded(this, EventArgs.Empty);
            }
        }

        void OnCategoryLoaded(Category category)
        {
            foreach (Book book in category.Books)
            {
                if (!books.ContainsKey(book.Title))
                {
                    books.Add(book.Title, book);
                    popular.Add(book);
                    latest.Add(book);
                }
            }

            popular.Sort(new PopularBookComparer());
            latest.Sort(new LatestBookComparer());
        }

        void OnLoadComplete()
        {
            popular.Sort(new PopularBookComparer());
            latest.Sort(new LatestBookComparer());

            isLoaded = true;

            EventHandler handler = LoadComplete;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        void OnImagesLoaded(bool serializeData)
        {
            EventHandler handler = ImagesLoaded;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }

            if (serializeData)
            {
                SerializeData();
            }
        }

        #endregion

        #region Implementation

        void AddCategory(string name, int maxBooksCount, int categoryName)
        {
            string url = string.Format("http://svcs.ebay.com/services/search/FindingService/v1?OPERATION-NAME=findItemsByCategory&SERVICE-VERSION=1.0.0&SECURITY-APPNAME=askme115e-b184-4942-93d7-14c64620781&RESPONSE-DATA-FORMAT=XML&REST-PAYLOAD&categoryId={0}&paginationInput.entriesPerPage={1}", categoryName, maxBooksCount);
            Category category = new Category(name, url);
            categories.Add(category.Name, category);

            category.LoadData(maxBooksCount, categoryName);

            OnCategoryLoaded(category);
        }

        object lockObject = new object();

        void SerializeData()
        {
            if (!Settings.Default.UseCache)
            {
                return;
            }

            try
            {
                lock (lockObject)
                {
                    string fileName = FileName;
                    XmlSerializer serializer = new XmlSerializer(typeof(Category[]));
                    using (FileStream writer = new FileStream(fileName, FileMode.Create))
                    {
                        serializer.Serialize(writer, categories.Values.ToArray<Category>());
                        writer.Close();
                    }

                    File.Copy(fileName, BackUpFileName, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool DeserializeData(string fileName)
        {
            if (!Settings.Default.UseCache || !File.Exists(fileName))
            {
                return false;
            }

            try
            {
                categories.Clear();
                XmlSerializer serializer = new XmlSerializer(typeof(Category[]));
                using (FileStream reader = new FileStream(fileName, FileMode.Open))
                {
                    Category[] categoriesArray = (Category[])serializer.Deserialize(reader);

                    foreach (Category category in categoriesArray)
                    {
                        categories.Add(category.Name, category);
                        foreach (Book book in category.Books)
                        {
                            book.Category = category;
                            if (!books.ContainsKey(book.Title))
                            {
                                books.Add(book.Title, book);
                                popular.Add(book);
                                latest.Add(book);
                            }
                        }
                    }
                    OnCategoryListLoaded();
                    OnLoadComplete();
                    OnImagesLoaded(false);

                    reader.Close();

                    this.Form.Invoke(new MethodInvoker(delegate()
                        {
                            this.Form.Text = "Last update: " + System.IO.File.GetCreationTime(fileName).ToString();
                        }));
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #region Comparers

        class PopularBookComparer : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                if (x.BidCount > y.BidCount) return 1;
                if (x.BidCount < y.BidCount) return -1;
                return 0;
            }
        }

        class LatestBookComparer : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                if (x.StartTime > y.StartTime) return 1;
                if (x.StartTime < y.StartTime) return -1;
                return 0;
            }
        }

        #endregion

        #endregion
    }
}

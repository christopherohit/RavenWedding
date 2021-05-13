using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using FindingAPI_WebApp_Sample.com.ebay.developer;


namespace BookShelf
{
    public class Category
    {
        const int maxItems = 30;

        #region Fields

        string name;
        string uri;
        List<Book> books = new List<Book>();
        ManualResetEvent isLoaded = new ManualResetEvent(false);

        #endregion

        #region Initialization

        public Category()
        {
            isLoaded.Set();
        }

        public Category(string name, string uri)
        {
            this.name = name;
            this.uri = uri;
        }

        #endregion

        #region Properties

        [XmlAttribute]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Uri
        {
            get
            {
                return uri;
            }
            set
            {
                uri = value;
            }
        }

        public List<Book> Books
        {
            get
            {
                return books;
            }
            set
            {
                books = value;
            }
        }

        [XmlIgnore]
        public ManualResetEvent IsLoaded
        {
            get
            {
                return isLoaded;
            }
        }

        #endregion

        #region Methods

        public void LoadData(int maxBooks, int categoryId)
        {
            CustomFindingService service = new CustomFindingService();
            service.Url = "http://svcs.ebay.com/services/search/FindingService/v1";

            FindItemsByCategoryRequest request = new FindItemsByCategoryRequest();
            request.categoryId = new string[] { categoryId.ToString() };

            // Setting the pagination 
            PaginationInput pagination = new PaginationInput();
            pagination.entriesPerPageSpecified = true;
            pagination.entriesPerPage = maxBooks * 2;
            request.paginationInput = pagination;

            // Sorting the result
            request.sortOrderSpecified = true;
            request.sortOrder = SortOrderType.CurrentPriceHighest;

            FindItemsByCategoryResponse response = service.findItemsByCategory(request);
            if (response.searchResult.count > 0)
            {
                books.Clear();
                foreach (SearchItem searchItem in response.searchResult.item)
                {
                    if (books.Count >= maxBooks)
                    {
                        break;
                    }

                    if (searchItem.title == null || searchItem.galleryURL == null)
                    {
                        continue;
                    }

                    books.Add(new Book(this, searchItem));
                }
            }
            else
            {
                MessageBox.Show("No results found for this category", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Implementation

        //void GetItemsCallback(IAsyncResult ar)
        //{
        //    if (!ar.IsCompleted)
        //    {
        //        return;
        //    }
        //    books.Clear();
        //    foreach (SearchItem item in BookShelfApp.Instance.Context.EndExecute<Item>(ar))
        //    {
        //        if (books.Count >= maxItems)
        //        {
        //            break;
        //        }
        //        if (item.Title == null || item.GalleryUrl == null)
        //        {
        //            continue;
        //        }
        //        books.Add(new Book(this, item));
        //    }
        //    IsLoaded.Set();
        //    OnLoadComplete();
        //}

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PageView
{
    class PageViewLabels
    {
        public static string[] Texts;
        public static int currIndex = 0;
        private static Font labelFont;

        static PageViewLabels()
        {
            Texts = new string[10];
            int index = 0;
            Texts[index++] = "Telerik® UI for WinForms includes more than 110 user interface controls you can use to fulfill the most demanding desktop or tablet application requirements. All-way customizable GridView, Form, Chart, Scheduler, RichTextBox and other essential controls enable you to build any Line of Business or Modern application in less time while staying under budget.";
            Texts[index++] = "All Telerik Windows Forms controls come with full theme support. You can use any of the 19 included themes (Windows 8, Office 2013, Visual Studio 2012), or build new ones with the intuitive and unique Visual Style Builder tool. The built-in themes help you effortlessly deliver sleek and consistent, next-generation user experiences across your desktop and tablet applications.";
            Texts[index++] = "Despite having animations and rich visual effects, Telerik® UI for WinForms controls feature excellent performance aimed at helping developers like you improve your productivity and deliver better and faster applications in less time. UI for WinForms enables easy development of complex, high-performing apps.";
            Texts[index++] = "Telerik WinForms controls integrate seamlessly into your Visual Studio Toolbox for quick drag and drop usage. Hundreds of demos, self-paced tutorials, videos and various other resources will get you started from day one. If you have worked with Microsoft’s Windows Forms Controls and WinForms .NET Framework, then you’ll easily work with Telerik® UI for WinForms. We offer excellent documentation, and should you need any help, you will get industry-leading tech support directly from the developers who created UI for WinForms—including during your evaluation period.";
            Texts[index++] = "Telerik® UI for Windows Forms is the first suite on the market to provide full multi-touch support and API out-of-the-box. The multi-touch API allows you to handle touch gestures occuring on the screen and take action, depending on what you need the Telerik WinForms controls to do. We also provide a set of ready to use multi-touch enabled controls (Grid, TreeView, Panorama, etc.) and Metro UI themes to start creating touch applications for desktop and tablets right away.";
            Texts[index++] = "To quickly instrument your WinForms application with an analytics service, Telerik® UI for WinForms features built-in integration with Telerik Analytics. Quickly access application usage data, including most popular features and run-time errors. The built-in analytics help you troubleshoot issues, reduce support, shape the application roadmap and decrease development costs.";
            Texts[index++] = "By following WPF best practices, the Telerik Presentation Framework (TPF) provides a completely customizable architecture for all WinForms controls. The uniform nature of the Telerik UI architecture makes it possible to nest controls within one another for more flexible and modern-looking user interfaces. This unique feature allows you to achieve previously impossible visual effects without having to write any code or learn a new technology. UI for WinForms just looks better, and the controls work on Windows XP, Windows Vista, Windows 7, as well as Windows 8.";
            Texts[index++] = "Business globalization makes multi-lingual and culturally-aware applications a must. Telerik WinForms controls can be used in all languages supported by the .NET framework, including right-to-left ones such as Arabic and Hebrew.";
            Texts[index++] = "Codelessly customize the appearance of all WinForms Controls with the help of a Visual Style Builder. A Control Spy helps you examine and change properties at run time. A Shape Editor can be used to define free-form UI elements for advanced interfaces. A Project Update Utility assists you in upgrading your Telerik UI-based applications to later versions. A convenient Element Hierarchy Editor allows you to work with complex control types, navigate the class and element hierarchy and set properties directly in Visual Studio design time.";
            Texts[index++] = "Telerik® UI for WinForms is the 1st third-party Windows Forms controls toolset to comply with the user interface accessibility and UI automation standards—Microsoft Active Accessibility (MSAA) and Coded UI tests. MSAA is a great automation tool that helps you access and manipulate all UI elements in applications that support it. UI for WinForms boasts full support for Coded UI Tests, implementing all four Coded UI Tests levels. The Coded UI Test automation functionality is available in both Visual Studio 2010 and Visual Studio 2012.";

            labelFont = new Font("Segoe UI", 10);
        }

        public static RadLabel CreateLabel(SizeF scaleSize)
        {
            if (currIndex >= Texts.Length)
            {
                currIndex = 0;
            }

            RadLabel label = new RadLabel();
            label.AutoSize = false;
            label.Font = labelFont;
            label.Dock = DockStyle.Fill;
            label.Text = Texts[currIndex++];
            label.TextAlignment = ContentAlignment.MiddleCenter;
            label.Scale(scaleSize);

            return label;
        }
    }
}

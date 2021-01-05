using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace smart_wardrobe
{
    /// <summary>
    /// Interaction logic for face.xaml
    /// </summary>
    public partial class face : Page
    {

        private List<string> path;
        public face(  List<string> paths, float _temp, string currentcity)

        {
            InitializeComponent();

            this.path = paths;
            txtbcity.Text = currentcity;
            
            getimage();

        }

        private void getimage()
        {
            for (int i = 0; i < path.Count; i++)
            {
                
            }
            
        }



        //private List<result> Getresult()
        //{
        //    return new List<result>()
        //    {
        //        new result("C:/Users/USER/source/repos/smart_wardrobe/bin/Debug/Assets/images/clear-day/female/0-20/accessories/img1.jbg"),
        //         new result("C:/Users/USER/source/repos/smart_wardrobe/bin/Debug/Assets/images/clear-day/female/0-20/accessories/img2.jbg"),
        //          new result("C:/Users/USER/source/repos/smart_wardrobe/bin/Debug/Assets/images/clear-day/female/0-20/accessories/img3.jbg"),
        //           new result("C:/Users/USER/source/repos/smart_wardrobe/bin/Debug/Assets/images/clear-day/female/0-20/accessories/img4.jbg"),
        //            new result("C:/Users/USER/source/repos/smart_wardrobe/bin/Debug/Assets/images/clear-day/female/0-20/accessories/img5.jbg"),

        //    };
        //}




    }
}
   

            
        
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

        private string[] path;
        public face(  string[] paths, float _temp, string currentcity)
        {
            
            InitializeComponent();
            path = paths ;
            getoutfit();
            txtbcity.Text = currentcity;

            //C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\clear-day\female\above-40\mainImgs

        }

        private List<result> getoutfit()
        {
            return new List<result> ()
                {
                new result(path[0]),//"clear-day/female/0-20/mainImgs/img1.jpg"
                new result(path[1]),//"clear-day/female/0-20/mainImgs/img2.jpg"
                new result(path[2])//"clear-day/female/0-20/mainImgs/img3.jpg"
            };
        }
    }
}
   

            
        
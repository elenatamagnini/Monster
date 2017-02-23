using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassi
{
    static class Assets
    {
#if DEBUG
        public static string assetsPath = @"..\..\assets\";
#else
        public static string assetsPath = @".\assets\";
#endif
        public static string imagesPath = assetsPath + @"images\";

        public static string getImagePath(string imageName)
        {
            return imagesPath + imageName + ".jpg";
        }
    }
}
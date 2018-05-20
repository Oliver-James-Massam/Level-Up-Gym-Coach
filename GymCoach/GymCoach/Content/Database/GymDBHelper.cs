using System;
using System.Configuration;

namespace Database
{
    public static class GymDBHelper
    {
        public static String ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

}
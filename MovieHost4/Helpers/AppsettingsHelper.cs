using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MovieHost4
{

    public class AppsettingsHelper
    {
        static IConfiguration Config = new ConfigurationBuilder()
            .AddJsonFile(getRootPath("appSettings.json"))
            .Build();

        static string getRootPath(string rootFilename)
        {
            string _root;
            var rootDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Regex matchThepath = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = matchThepath.Match(rootDir).Value;
            _root = Path.Combine(appRoot, rootFilename);

            return _root;
        }

        public static string ApiKey
        {
            get
            {
                return Config.GetSection("APIData")["Key"];
            }
        }
        public static string TopratedMoviesUrl
        {
            get
            {
                return Config.GetSection("APIData")["TopratedMoviesUrl"];
            }
        }

        public static string UpcomingMoviesUrl
        {
            get
            {
                return Config.GetSection("APIData")["UpcomingMoviesUrl"];
            }
        }

        public static string NowPlayingMoviesUrl
        {
            get
            {
                return Config.GetSection("APIData")["NowPlayingMoviesUrl"];
            }
        }
    }
}

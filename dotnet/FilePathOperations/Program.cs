namespace Solution
{
    class FileMaster
    {
        //--> https://www.codewars.com/kata/5844e0890d3bedc5c5000e54

        private static string _filepath = string.Empty;

        public static void Main()
        {
            FileMaster FM = new FileMaster("/Users/person1/Pictures/house.png");
            var x = FM.extension();
            var y = FM.filename();
            var z = FM.dirpath();
        }

        public FileMaster(string filepath)
        {
            _filepath = filepath;
        }

        public string extension()
        {
            return Path.GetExtension(_filepath).Substring(1);
        }

        public string filename()
        {
            return Path.GetFileNameWithoutExtension(_filepath);
        }

        public string dirpath()
        {
            var dp = _filepath.Split("/");
            var newdp = dp.SkipLast(1).ToArray();            
            return string.Join("/", newdp) + "/";
        }
    }
}
using System;


namespace BasicWebServer
{
    public class Header
    {
        System.Collections.Specialized.NameValueCollection headersCollections;
        public Header(System.Collections.Specialized.NameValueCollection header)
        {
            headersCollections = header;
        }

        public void printAllInfos()
        {
            Console.WriteLine("----- Headers -----");
            Console.WriteLine(this.headersCollections);
        }

        public void printHeader(string header)
        {
            Console.WriteLine("----- Header asked :" + header + "-----");
            Console.WriteLine(this.headersCollections.Get(header));
        }

        public System.Collections.Specialized.NameValueCollection getHeaders()
        {
            return headersCollections;
        }
    }
}

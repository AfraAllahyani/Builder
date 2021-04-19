using System;

namespace Builder
{
    class Program
    {
        class grbBuilder
        {
            private string rgbFormatter;
            public grbBuilder()
            {
                this.rgbFormatter = "";
            }
            public grbBuilder beginTag()
            {
                this.rgbFormatter += "color: rgb(";
                return this;
            }
            public grbBuilder setColors(int red, int green, int blue)
            {
                this.rgbFormatter += red + "," + green + "," + blue;
                return this;
            }
            public grbBuilder endTag()
            {
                this.rgbFormatter += ")";
                return this;
            }
            public string getFormat()
            {
                return this.rgbFormatter;
            }

        }

        static void Main(string[] args)
        {
            grbBuilder obj = new grbBuilder();
            string grbFormat =
                obj.beginTag()
                .setColors(255, -10, 0)
                .endTag()
                .getFormat();
            Console.WriteLine(grbFormat);

        }
    }
}

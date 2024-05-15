using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKonMarketplace.Data.Models.Constants
{
    internal class EntityConstants
    {
        public const string DefaultPassword = "123456";

        public static class OfferConstants
        {
            public const int TitleMaxLenght = 20;
            public const int LoactionMaxLenght = 50;
            public const int DescriptionMaxLenght = 200;
            public const int PriceMinValue = 0;
            public const int PriceMaxValue = 1000000;
        }

        public static class BreedConstants
        {
            public const int NameMaxLength = 50;
        }

        public static class SellerConstants
        {
            public const int PhoneNumberMaxLength = 15;
        }


    }
}

using System;

using Microsoft.Bot.Builder.FormFlow;

namespace KodakBot
{

    public enum OrderOptions { PrintASinglePhoto, PrintMultiplePhotos }
    public enum SizeOptions { FourXSix, FiveXSeven, SixXNine }
    public enum PickupStoreOptions { CVS, RiteAid, Walgreens, Target }

    [Serializable]
    public class PhotoOrder
    {

        [Prompt("\nWhat can I help you with? {||}")]
        public OrderOptions? OrderType;

        [Prompt("\nWhat? {||}")]
        public SizeOptions? Size;

        [Prompt("\nGreat, what's your {&}?")]
        public int Zipcode;

        [Prompt("\nWe have several stores in your area, where would you like to pick up your prints? {||}")]
        public PickupStoreOptions? Store;

        public static IForm<PhotoOrder> BuildForm()
        {
            return new FormBuilder<PhotoOrder>()
                    //.Message("Welcome to the Kodak bot!")
                    .Build();
        }
    }
}

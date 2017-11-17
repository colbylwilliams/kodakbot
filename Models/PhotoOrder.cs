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

        [Prompt("\nWhat can I help you with? {||}", ChoiceFormat = "{0}", ChoiceCase = CaseNormalization.Lower)]
        public OrderOptions? Order;

        [Prompt("\nWhat size prints would you like? {||}", ChoiceFormat = "{0}", ChoiceCase = CaseNormalization.Lower)]
        public SizeOptions? Size;

        [Prompt("\nGreat, what's your five-digit {&}?")]
        public int Zipcode;

        [Prompt("\nWe have several stores in your area, where would you like to pick up your prints? {||}", ChoiceFormat = "{0}")]
        public PickupStoreOptions? Store;

        public static IForm<PhotoOrder> BuildForm()
        {
            return new FormBuilder<PhotoOrder>()
                .Message("Welcome to the Kodak bot!")
                .Field(nameof(Order))
                .Field(nameof(Size))
                .Field(nameof(Zipcode))
                .Field(nameof(Store))
                .Build();
        }
    }
}

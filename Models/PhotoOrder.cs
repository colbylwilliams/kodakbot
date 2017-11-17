using System;

using Microsoft.Bot.Builder.FormFlow;

namespace KodakBot
{
    public enum OrderTypeOptions { SinglePhoto, MultiplePhotos }
    public enum SizeOptions { FourBySix, FiveBySeven, SixByNine }
    public enum PickupStoreOptions { CVS, RiteAid, Walgreens, Target }

    [Serializable]
    public class PhotoOrder
    {
        public OrderTypeOptions? OrderType;
        public SizeOptions? Size;
        public PickupStoreOptions? Store;

        public static IForm<PhotoOrder> BuildForm()
        {
            return new FormBuilder<PhotoOrder>()
                    .Message("Welcome to the Kodak bot!")
                    .Build();
        }
    }
}

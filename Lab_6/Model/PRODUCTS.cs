//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_6.Model
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class PRODUCTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTS()
        {
            this.USERS2 = new ObservableCollection<USERS>();
        }

        public int ID_PRODUCT { get; set; }
        public string TITLE { get; set; }
        public decimal PRICE { get; set; }
        public System.DateTime ENDTIME { get; set; }
        //{
        //    get
        //    {
        //        DateTime now = new DateTime();
                

        //        return (new DateTime() + DateTime.Now);
        //        //return (System.DateTime)((System.DateTime)ENDTIME - now);
        //    }
        //    set
        //    {
        //        ENDTIME = value;
        //    }
        //}
        public Nullable<int> BIDS { get; set; }
        public string PROD_DESCRIPTION { get; set; }
        public string TYPE_PROD { get; set; }
        public Nullable<int> IMAGE_PROD { get; set; }
        public Nullable<int> OWNER_ID { get; set; }
        public Nullable<int> TOP_BID_USER_ID { get; set; }
        [NotMapped]
        private string _imageLink;
        [NotMapped]
        public string PRODUCT_IMAGE_LINK
        {
            set
            {
                _imageLink = DataWorker.SetImageLinkToProduct(this, value); //value is srting

            }
            get
            {
                return _imageLink ?? DataWorker.GetImageLinkByProdImgID(IMAGE_PROD);
            }
        }


        public virtual IMAGES IMAGES { get; set; }
        public virtual USERS USERS { get; set; }
        public virtual USERS USERS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<USERS> USERS2 { get; set; }
    }
}

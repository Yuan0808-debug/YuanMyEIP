//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 通知
    {
        public int 通知流水號 { get; set; }
        public Nullable<int> 通知類別id { get; set; }
        public string 通知內容 { get; set; }
        public string 讀取狀態 { get; set; }
        public string 通知權限 { get; set; }
    
        public virtual 通知類別 通知類別 { get; set; }
    }
}

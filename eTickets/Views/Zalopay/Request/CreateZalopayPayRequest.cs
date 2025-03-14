namespace eTickets.Views.Zalopay.Request
{
    public class CreateZalopayPayRequest
    {
        public CreateZalopayPayRequest(int appId ,string appUser, long appTime, string appTransId, string description, string bankCode, long amount)
        {
            AppId = appId;
            AppUser = appUser;
            AppTime = appTime;
            AppTransId = appTransId;
            Description = description;
            BankCode = bankCode;
            Amount = amount;
        }
        public int AppId { get; set; }
        public string AppUser { get; set; } = string.Empty;
        public long AppTime { get; set; }
        public long Amount { get; set; }
        public string AppTransId { get; set; } = string.Empty;
        public string ReturnUrl { get; set; }
        public string EmbedData { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BankCode { get; set; } = string.Empty;
        public string Mac { get; set; } = string.Empty;
        
    }
}

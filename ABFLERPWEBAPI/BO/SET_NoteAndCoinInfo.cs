using System.ComponentModel.DataAnnotations;

namespace ABFLERPWEBAPI.BO
{
    public class SET_NoteAndCoinInfo
    {
        private byte _ID;
        private string _MoneyNoteorCoin;

        public byte ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }

        public string MoneyNoteorCoin
        {
            get
            {
                return this._MoneyNoteorCoin;
            }
            set
            {
                this._MoneyNoteorCoin = value;
            }
        }

        public Decimal Amount { get; set; }

        public bool IsCoin { get; set; }

        public bool IsActive { get; set; }

        public Decimal TotalAmount { get; set; }

        public int NoOfNote { get; set; }

        public long ChallanID { get; set; }

        public byte NoteID { get; set; }

        public Decimal AreaLedgerAmount { get; set; }
    }
}

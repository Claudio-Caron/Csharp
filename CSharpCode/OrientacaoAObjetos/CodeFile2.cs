class Conta
{
    private string PersonName { get; set; }
    public float Balance
    { get => Balance;
        set
        {
            if (value > 0)
            {
                Balance = value;
            }
        }
    }
    public Conta(string PersonName)
    {
       this.PersonName = PersonName; 
       Balance = 1000;
    }




}
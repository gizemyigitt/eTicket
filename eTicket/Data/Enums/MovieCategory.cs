namespace eTicket.Data.Enums
{
    //bir çok film türünü barındıracağı için bir enum yapısı oluştururuz
    public enum MovieCategory
    {
        Action = 1,//start index ekledik burdan yola çıkarak diğer değerlere id atanacaktır
        Comedy,
        Drama,
        Documentary,
        Cartoon,
        Horror
    }
}

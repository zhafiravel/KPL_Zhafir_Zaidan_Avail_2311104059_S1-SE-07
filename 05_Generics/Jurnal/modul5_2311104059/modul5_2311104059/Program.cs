using modul5_2311104059;

class Program
{
    static void Main()
    {
        SimpleDataBase<int> dataBase = new SimpleDataBase<int>();
        dataBase.AddNewData(12);
        dataBase.AddNewData(34);
        dataBase.AddNewData(56);
        dataBase.PrintAllData();
    }
}
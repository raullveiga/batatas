using System;
using NetOffice.ExcelApi; 

namespace matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
         string[,] sacola = {{"id","produto","preco"},{"54","calça","R$100,00"},{"105","blusa","R$56,00"}};
        
        
        Application ex = new Application();

        ex.Visible = true;//Abre o excel
        ex.Workbooks.Add();//adiciona uma planilha em branco
        ex.Range("A1").Select();//seleciona a primeira célula
        
        
        for(int i=0;i<sacola.GetLength(0);i++){
            for(int j=0;j<sacola.GetLength(1);j++)
        //      Console.Write(sacola[i,j]+"\t");
                ex.Cells[i+1,j+1].Value=sacola[i,j];
        }

        ex.ActiveWorkbook.SaveAs("batta.xlsx");
        ex.Quit();//fechar o excel



        }
    }
}

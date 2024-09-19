string[] values = {"12,3", "45", "ABC", "11", "DEF"}; //fijarse que en vez de punto pongamos coma para que lo reconozca
var letras ="";
var totalNum=0.0;

foreach (var valor in values){
    
    if (double.TryParse(valor,out double num)){
        totalNum += num;
    }else{
        letras += valor;
    }
}

Console.WriteLine($"Letras: {letras}");
Console.WriteLine($"Total: {totalNum}");


class Pessoa
{
    public double peso;
    public double altura;
 
    public double IMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    public string MensagemIMC(double imc)
    {
        string mensagem = "";
        
        if(imc < 18.5)
            mensagem = "< 18,5 - Abaixo do peso";
        else if(imc < 25)
            mensagem = "< 25 - Peso normal";
        else if(imc < 30)
            mensagem = "< 30 - Acima do peso";
        else if(imc < 35)
            mensagem = "< 35 - Obesidade I";
        else if(imc < 40)
            mensagem = "< 40 - Obesidade II";
        else if(imc >= 40)
            mensagem = ">= 40 - Obesidade III";
        
        return mensagem;

    }
}
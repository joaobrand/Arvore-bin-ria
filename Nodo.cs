public class Nodo{
    private Nodo no_pai = null;
    private Nodo no_direita = null;
    private Nodo no_esquerda = null;
    private int valor = 0;


public int get_valor(){
return valor;
}
public void set_valor(int v){
    valor = v;
}
public void set_no_pai(Nodo no){
    no_pai = no;
}  

public void set_no_esquerda(Nodo no){
    no_esquerda= no;
}
public void set_no_direita(Nodo no){
    no_direita = no;

}
public Nodo  get_no_pai(){
return no_pai;
}
public Nodo get_no_direita(){
 return no_direita:
}
public Nodo get_no_esquerda(){
    return no_esquerda;
}
}

using System;

class Arvore_binaria {
private Nodo raiz = null;
private int qntd =0;
private string result = "";

public int qntd_nos_internos(){
 return qntd;
}

public bool no_externo(Nodo no){
    return(no.get_no_direita() == null ) && (no.get_no_esquerda() == null);
}

public Nodo cria_no(Nodo Nopai){
    Nodo no = new Nodo();
    no.set_no_pai(Nopai);
    return no;

}
public void insere(int valor){
 Nodo no_aux;
 if(qntd == 0){
     // cria o primeiro Nodo
     no_aux = new Nodo();
     raiz = no_aux;

// Aqui começa a localizar o nó onde de ve ser inserido


 } else{
     no_aux = raiz;
     while(no_externo(no_aux) == false){
         if(valor > no_aux.get_valor())
         no_aux = no_aux.get_no_direita();
         else
         no_aux= no_aux.get_no_esquerda();
     }
 }

 // criando novos filhos ao nó pai inserido
no_aux.set_valor(valor);
no_aux.set_no_direita(cria_no(no_aux));
no_aux.set_no_esquerda(cria_no(no_aux));
}

private void Le_nodo(Nodo no){

 if(no_externo(no)) return;

 Le_nodo(no.get_no_esquerda());
 result =result+ Convert.ToInt32(no.get_valor()); // transforma string em inteiro 
 Le_nodo(no.get_no_direita());
}
 public string Lista(){
result = "";
Le_nodo(raiz);
return result;
 }

}
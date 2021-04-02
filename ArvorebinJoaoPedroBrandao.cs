using System;

class Arvore_binari: ProgramaArvoreBinaria {

ArvoreBinaria arvoreBinaria = new ArvoreBinaria();
ProgramaArvoreBinaria prograArvorebina = new ProgramaArvoreBinaria();


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
 //inserindo valores aos nós e montando a árvore abstratamente 
 public void Cria_Arvore()
		{
			raiz = new No('A');
			raiz.set_no_esquerda = new No('B');
			raiz.set_no_direita = new No('C');
			raiz.set_no_esquerda.set_no_esquerda = new No('D');
			raiz.set_no_esquerda.set_no_direita= new No('E');
			raiz.set_no_direita.set_no_esquerda = new No('F');
		}
// mostrando a arvore
public void ExibirArvore()
			{
			ExibirArvore(raiz, 0);
			Console.WriteLine();
		    }
public void Exibir(Nodo no, int ini)
		{
			int i;

			if (no == null)
				return;

			ExibirArvore(no.get_no_direita, ini + 1);
			Console.WriteLine();

			for (i = 0; i < ini; i++)
				Console.Write("    ");

			Console.WriteLine(no.Le_nodo);

			
		}

}
        // mostrando o percurso da arv do professor

       arvoreBinaria.CriarArvore();
			
			
			arvoreBinaria.Exibir();
			Console.WriteLine();

			Console.WriteLine("pre-ordem: ");
			arvoreBinaria.PercorrerPreOrdem();
			Console.WriteLine();

			Console.WriteLine("em ordem: ");
			arvoreBinaria.PercorrerEmOrdem();
			Console.WriteLine();

			Console.WriteLine("pos-ordem: ");
			arvoreBinaria.PercorrerPosOrdem();
			Console.WriteLine();

			Console.WriteLine("ordenado por nivel: ");
			arvoreBinaria.PercorrerOrdemPorNivel();
			Console.WriteLine();
			

			
       
}
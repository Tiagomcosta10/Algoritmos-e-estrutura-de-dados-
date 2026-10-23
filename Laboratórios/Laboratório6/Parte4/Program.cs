using System;

public class pilha{
int[] item;
int topo;

public pilha(int maxTam){
item=new int[maxTam];
topo=0;
}

public bool vazia(){
return topo==0;
}

public bool cheia(){
return topo==item.Length;
}

public int tamanho(){
return topo;
}

public void empilha(int x){
if(cheia()) throw new Exception("Erro: pilha cheia");
item[topo++]=x;
}

public int desempilha(){
if(vazia()) throw new Exception("Erro: pilha vazia");
return item[--topo];
}

public int consultaTopo(){
if(vazia()) throw new Exception("Erro: pilha vazia");
return item[topo-1];
}
}

class program{
static int[] bubble(int[] v, out int c){
c=0;
int n=v.Length;
pilha a=new pilha(n);
pilha b=new pilha(n);
pilha r=new pilha(n);

for(int i=0;i<n;i++){
a.empilha(v[i]);
}

for(int j=n;j>=1;j--){
int aux=a.desempilha();

for(int i=0;i<j-1;i++){
int x=a.desempilha();
c++;

if(aux>x){
b.empilha(x);
}else{
b.empilha(aux);
aux=x;
}
}

r.empilha(aux);

pilha temp=a;
a=b;
b=temp;
}

int[] res=new int[n];
for(int i=0;i<n;i++){
res[i]=r.desempilha();
}

return res;
}

static void Main(string[] args){
int[] v1={5,2,9,1,7};
int comp1;
int[] res1=bubble(v1,out comp1);


Console.WriteLine("Entrada: { 5, 2, 9, 1, 7 }");
Console.WriteLine("Resultado: { "+string.Join(", ",res1)+" }");
Console.WriteLine("Comparações: "+comp1);
Console.WriteLine();

int[] v2={1,2,5,7,9};
int comp2;
int[] res2=bubble(v2,out comp2);


Console.WriteLine("Entrada: { 1, 2, 5, 7, 9 }");
Console.WriteLine("Resultado: { "+string.Join(", ",res2)+" }");
Console.WriteLine("Comparações: "+comp2);
}
}

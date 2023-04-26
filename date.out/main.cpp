#include <fstream>
//a. valoarea minimă citită.
//b. valoarea maximă citită şi de câte ori apare această valoare în şirul valorilor citite
//c. cel mai mare număr par
//d. valoarea x cu cea mai mare sumă a cifrelor.
using namespace std;
int n, min1, max1, k=0, s=0, x, i, maxp, smax, aux, rez;
int main()
{
    ifstream fin ("date.in");
    ofstream fout ("date.out");
   fin>>n;
   min1=1000000000;
   max1=-1000000000;
   maxp=-1000000000;
   smax=-1000000000;
   for(i=1; i<=n; i++){
    fin>>x;
    aux=x;
    if(x<min1)
        min1=x;
    if(x>max1){
        max1=x;
        k=1;
    }
    else if(x==max1)
        k++;
    if(x>maxp && x%2==0)
        maxp=x;
    while(aux){
        s=aux+aux%10;
        aux=aux/10;
    }
    if(s>smax){
        smax=s;
        rez=x;
        }
   }
   fout<<min1<<" "<<max1<<" "<<k<<" "<<maxp<<" "<<rez;
   fin.close();
   fout.close();
    return 0;
}

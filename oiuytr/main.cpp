#include <iostream>

using namespace std;

int main()
{
    int n, a, max, i;
    cout<<"n="; cin>>n;
     cout<<"a="; cin>>a;
    for(i=1; i<=n; i++){

       max=a%10;
       a=a/10;
       while(a){
        if((a%10)>max){
            max=a;
        }
       }
    }
    cout<<max;

    return 0;
}

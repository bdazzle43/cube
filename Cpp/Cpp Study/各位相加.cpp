#include<iostream>
using namespace std;
int num(int x)//判断输入的整数的位数 
{
    int aa=1,bb=0;
    while(x/aa>0)
    {
                bb=bb+1;
                aa=aa*10;
    }
    return bb;
}

int numb(int wei,int x)//判断整数a在最高位上的数字是多少 
{
    int aa=1,bb=0;
    while(wei>1)
    {
            aa=aa*10;
            wei=wei-1;
    }
            
    bb=x/aa;
    return bb;
}
    
                   
int main()
{
    int x,y,wei;int s=0,aa=1,bb;
    cout<<"输入一个整数求其各位上的数之和：";
    cin>>x;
    wei=num(x);bb=wei;
            
         while(wei>0)
         {   
            s=s+numb(wei,x);
            while(bb>1)
            {
                  aa=aa*10;
                  bb=bb-1;
            }
            x=x-aa*numb(wei,x);
            wei=wei-1;bb=wei;aa=1;
         }

    
    
    cout<<"各位上的数之和为："<<s<<endl;
                     

    system("pause");
}
    

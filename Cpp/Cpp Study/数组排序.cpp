#include<iostream>
using namespace std;

void paixu1()//冒泡法 
{

    int b[100],nn,ii=0,tm,a;
    cout<<"冒泡法排序\n"<<"请输入要排序的数字，输入-1结束！\n";
    b[0]=0;//防止内存中本来就是-1
    while(b[ii]!=-1)
    {
                   ii++;
                   cout<<"数字"<<ii<<":"; 
                   cin>>b[ii];
    }
    a=1;
    while(a<ii)
    {
               for(nn=1;nn<ii-1;nn++) if(b[nn]>b[nn+1])swap(b[nn],b[nn+1]);
               a++;
    }   
    for(tm=1;tm<ii;tm++)cout<<b[tm]<<" ";
    cout<<endl;          

}

void paixu2()//插入法 
{
    int a[100],n,i=0,tmp,m;
    cout<<"插入法排序\n"<<"请输入要排序的数字，输入-1结束！\n";
    a[0]=0;//防止内存中本来就是-1
    while(a[i]!=-1)
    {
                   i++;
                   cout<<"数字"<<i<<":"; 
                   cin>>a[i];
    }
    
    /*排序*/ 
    for(n=2;n<i;n++)
    {
        for(m=n;m>1;m--)
        {
                    if(a[m]<a[m-1])swap(a[m],a[m-1]);
        }
    }
    for(tmp=1;tmp<i;tmp++)cout<<a[tmp]<<" ";
    cout<<endl;
   
} 

int main()
{
    int c=0;
    cout<<"请选择要求排序的方法：\n";
    cout<<"1.冒泡法       2.插入法\n"; 
    cout<<"选择：";cin>>c; 
    if(c==1)paixu1(); else
    if(c==2)paixu2(); else cout<<"error!\n";
    system("pause");
}

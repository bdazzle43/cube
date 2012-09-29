//P72-11
#include <iostream>
using namespace std;
int main()
{
    int i,a;double aa=0,bb=0,cc=0,dd=0,ff=0,gg=0,aaa=0,bbb=0,aaaa=0,bbbb=0;
    cout<<"请输入10个整数：\n";
    for(i=1;i<=10;i++)
    {
                     cout<<"第"<<i<<"个数:";
                     cin>>a;
                     if(a>0){aa=aa+a;bb=bb+1;}
                     if(a<0){cc=cc+a;dd=dd+1;}
                     if(a==0)ff=ff+1;
                     gg=gg+a;
                     }
                     if(bb!=0)aaa=aa/bb;//防止平均数中除以0
                     if(dd!=0)bbb=cc/dd;
                     if(bb+ff!=0)aaaa=aa/(bb+ff); 
                     if(dd+ff!=0)bbbb=cc/(dd+ff);
                     cout<<"10个数中："<<endl<<endl;
                     cout<<"正数有"<<bb<<"个，和为："<<aa<<"   平均数为："<<aaa<<endl;
                     cout<<"非负数有"<<bb+ff<<"个，和为："<<aa<<"   平均数为："<<aaaa<<endl;
                     cout<<"负数有"<<dd<<"个，和为："<<cc<<"   平均数为："<<bbb<<endl;
                     cout<<"非正数有"<<dd+ff<<"个，和为："<<cc<<"   平均数为："<<bbbb<<endl;
                     cout<<"所有数平均数为："<<gg/10<<endl;
                     system("pause");
                     }

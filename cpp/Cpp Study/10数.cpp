//P72-11
#include <iostream>
using namespace std;
int main()
{
    int i,a;double aa=0,bb=0,cc=0,dd=0,ff=0,gg=0,aaa=0,bbb=0,aaaa=0,bbbb=0;
    cout<<"������10��������\n";
    for(i=1;i<=10;i++)
    {
                     cout<<"��"<<i<<"����:";
                     cin>>a;
                     if(a>0){aa=aa+a;bb=bb+1;}
                     if(a<0){cc=cc+a;dd=dd+1;}
                     if(a==0)ff=ff+1;
                     gg=gg+a;
                     }
                     if(bb!=0)aaa=aa/bb;//��ֹƽ�����г���0
                     if(dd!=0)bbb=cc/dd;
                     if(bb+ff!=0)aaaa=aa/(bb+ff); 
                     if(dd+ff!=0)bbbb=cc/(dd+ff);
                     cout<<"10�����У�"<<endl<<endl;
                     cout<<"������"<<bb<<"������Ϊ��"<<aa<<"   ƽ����Ϊ��"<<aaa<<endl;
                     cout<<"�Ǹ�����"<<bb+ff<<"������Ϊ��"<<aa<<"   ƽ����Ϊ��"<<aaaa<<endl;
                     cout<<"������"<<dd<<"������Ϊ��"<<cc<<"   ƽ����Ϊ��"<<bbb<<endl;
                     cout<<"��������"<<dd+ff<<"������Ϊ��"<<cc<<"   ƽ����Ϊ��"<<bbbb<<endl;
                     cout<<"������ƽ����Ϊ��"<<gg/10<<endl;
                     system("pause");
                     }

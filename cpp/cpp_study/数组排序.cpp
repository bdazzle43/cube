#include<iostream>
using namespace std;

void paixu1()//ð�ݷ� 
{

    int b[100],nn,ii=0,tm,a;
    cout<<"ð�ݷ�����\n"<<"������Ҫ��������֣�����-1������\n";
    b[0]=0;//��ֹ�ڴ��б�������-1
    while(b[ii]!=-1)
    {
                   ii++;
                   cout<<"����"<<ii<<":"; 
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

void paixu2()//���뷨 
{
    int a[100],n,i=0,tmp,m;
    cout<<"���뷨����\n"<<"������Ҫ��������֣�����-1������\n";
    a[0]=0;//��ֹ�ڴ��б�������-1
    while(a[i]!=-1)
    {
                   i++;
                   cout<<"����"<<i<<":"; 
                   cin>>a[i];
    }
    
    /*����*/ 
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
    cout<<"��ѡ��Ҫ������ķ�����\n";
    cout<<"1.ð�ݷ�       2.���뷨\n"; 
    cout<<"ѡ��";cin>>c; 
    if(c==1)paixu1(); else
    if(c==2)paixu2(); else cout<<"error!\n";
    system("pause");
}

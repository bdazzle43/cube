//����42���˵ķ���������߷�������ƽ������
#include<iostream>
using namespace std;
int main()
{
    int max,score[5],i;
    double he;
    cout<<"������5���˵ķ���\n"; 
    for(i=0;i<5;i++)
    {
                    cout<<"����"<<i+1<<":";
                    cin>>score[i];
    }
    cout<<"������...\n";
    max=0;
    he=0;
    for(i=0;i<5;i++)
    {
                    if(score[i]>max)max=score[i];
                    he=he+score[i];
    }
    cout<<"��߷�:"<<max<<endl<<"ƽ����:"<<he/5<<endl;
    cout<<"�������\n";
    system("pause");
}

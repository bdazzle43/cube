//班上42个人的分数，求最高分数，很平均分数
#include<iostream>
using namespace std;
int main()
{
    int max,score[5],i;
    double he;
    cout<<"请输入5个人的分数\n"; 
    for(i=0;i<5;i++)
    {
                    cout<<"分数"<<i+1<<":";
                    cin>>score[i];
    }
    cout<<"计算中...\n";
    max=0;
    he=0;
    for(i=0;i<5;i++)
    {
                    if(score[i]>max)max=score[i];
                    he=he+score[i];
    }
    cout<<"最高分:"<<max<<endl<<"平均分:"<<he/5<<endl;
    cout<<"程序结束\n";
    system("pause");
}

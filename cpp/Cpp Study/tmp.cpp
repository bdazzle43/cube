#include<iostream>
#include<cmath>
using namespace std;



int IsLeapYear(int y)   //判断某一年是否闰年
{
  return (y%4 == 0 && y%100 != 0)+(y%400 == 0);
}  

int DaysOfYear(int year,int month=12,int day=31)   //判断当天是当年的第几天 
{
  int days=0;
  days=day+31*(month>1)+28*(month>2)*(IsLeapYear(year)==0)+29*(month>2)*(IsLeapYear(year)!=0)
          +31*(month>3)+30*(month>4)+31*(month>5)+30*(month>6)+31*(month>7)+31*(month>8)
          +30*(month>9)+31*(month>10)+30*(month>11);
  return days;
}

int yeartoyear(int y1,int m1,int d1,int y2,int m2,int d2)//两天差 
{
    int days=0;
    if (y1==y2) 
        {
                if (m1==m2) days=abs(d1-d2);
                if (m1>m2)
                   {
                          swap(y1,y2);swap(m1,m2);swap(d1,d2);
                          days=DaysOfYear(y2,m2,d2)-DaysOfYear(y1,m1,d1);
                   }
                if (m1<m2) days=DaysOfYear(y2,m2,d2)-DaysOfYear(y1,m1,d1);
        }
    else
    {
        if ( max(y1,y2)==y1) {swap(y1,y2);swap(m1,m2);swap(d1,d2);}
        for(int i=y1+1;i<y2;i++)days=days+DaysOfYear(i);
        days=days+DaysOfYear(y1)-DaysOfYear(y1,m1,d1)+DaysOfYear(y2,m2,d2);
    }
    return days;
}
int main()
{
    int y1,m1,d1,y2,m2,d2;
    cin>>y1>>m1>>d1>>y2>>m2>>d2;
    cout<<yeartoyear(y1,m1,d1,y2,m2,d2);
    system("pause");
}

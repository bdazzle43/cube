#include<iostream>
using namespace std;

int a[13]={0,31,29,31,30,31,30,31,31,30,31,30,31}; // 29

int IsLeapYear(int y)   //�ж�ĳһ���Ƿ�����
{
  return (y%4 == 0 && y%100 != 0)+(y%400 == 0);
}  

int DaysOfYear(int year,int month,int day)   //�жϵ����ǵ���ĵڼ��� 
{
  int days=0;
  days=day+31*(month>1)+28*(month>2)*(IsLeapYear(year)==0)+29*(month>2)*(IsLeapYear(year)!=0)
          +31*(month>3)+30*(month>4)+31*(month>5)+30*(month>6)+31*(month>7)+31*(month>8)
          +30*(month>9)+31*(month>10)+30*(month>11);
  return days;
}

int main()
{
    int year,month,day,aa=0;
    while(aa==0)
    {
      cout<<"������������\n";
      cout<<"�꣺"; cin>>year;
      cout<<"�£�"; cin>>month;
      cout<<"�գ�"; cin>>day;
      if (month>12 || month<1 || day>a[month] || day<1)
        cout<<"����������������������룡\n";
      else
        break;
    }           
      cout<<DaysOfYear(year,month,day);
      
    system("pause");
}

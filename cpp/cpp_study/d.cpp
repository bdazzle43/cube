#include<iostream>
using namespace std;

int begin()
{
     int choice;
     do
     {
            system("cls");
            cout<<"                                                                                ";
            cout<<"                      **********************************                        ";
            cout<<"                      *                                *                        ";
            cout<<"                      *        ʱ �� �� ��  V1.0       *                        ";
            cout<<"                      *                                *                        ";
            cout<<"                      *             by Faye            *                        ";
            cout<<"                      *                                *                        ";
            cout<<"                      **********************************                        ";
            cout<<"                                                                                ";
            cout<<"                              1. �� �� �� ѯ                                    ";
            cout<<"                              2. �� �� �� ѯ                                    ";
            cout<<"                              3. �� �� �� ѯ                                    ";
            cout<<"                              4. �� �� �� ��                                    ";
            cin>>choice;
     }while(choice>4 || choice<1);
     return choice;
            
            
            
            system("pause");
}




int main()
{
    begin();
}

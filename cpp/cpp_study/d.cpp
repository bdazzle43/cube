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
            cout<<"                      *        时 间 工 具  V1.0       *                        ";
            cout<<"                      *                                *                        ";
            cout<<"                      *             by Faye            *                        ";
            cout<<"                      *                                *                        ";
            cout<<"                      **********************************                        ";
            cout<<"                                                                                ";
            cout<<"                              1. 日 期 查 询                                    ";
            cout<<"                              2. 节 日 查 询                                    ";
            cout<<"                              3. 日 历 查 询                                    ";
            cout<<"                              4. 关 于 程 序                                    ";
            cin>>choice;
     }while(choice>4 || choice<1);
     return choice;
            
            
            
            system("pause");
}




int main()
{
    begin();
}

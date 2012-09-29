
#include <stdio.h>
#include <windows.h>
void GoToXY(int x, int y);
void WhereXY(int *x, int *y);

int main()
{
 int x,y;

 printf("Now go to (20,3)");
 GoToXY(20,3);

 //getXY
 WhereXY(&x,&y);
 printf("x=%d,y=%d",x,y);
 system("pause");

}
void GoToXY(int x, int y)
{
 COORD pos = {x,y};
 HANDLE hOut = GetStdHandle(STD_OUTPUT_HANDLE); // 获取标准输出设备句柄
 
 SetConsoleCursorPosition(hOut, pos);
}

void WhereXY(int *x, int *y)
{
 HANDLE hOut = GetStdHandle(STD_OUTPUT_HANDLE); // 获取标准输出设备句柄
 CONSOLE_SCREEN_BUFFER_INFO bInfo;
    GetConsoleScreenBufferInfo( hOut, &bInfo ); 
 COORD pos = bInfo.dwCursorPosition;
 *x = pos.X;
 *y = pos.Y;
}
 

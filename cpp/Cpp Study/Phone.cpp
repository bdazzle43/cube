#include <iostream>
#include <fstream>
#include <math.h>
using namespace std;



/***********手机类***********/
class Phone
{
	private:
		int Number;    //手机号码
		string Address,Card;    //手机归属地,卡类型
	public:
		Phone(){}
		Phone(int);
		Phone(int,string,string);
		void setNumber(int );       //设置号码
	    bool checkNumber(int);     //检查号码合法性
		void setAddress(string );   //设置手机地址
		void setCard(string );      //设置手机卡类型
		int getNumber();            //获取号码
		string getAddress();        //获取地址
		string getCard();           //获取卡类型
		void error(int );           //错误提示
		void show();


};

Phone::Phone(int n)
{
	if (checkNumber(n))
	{
		setNumber(n);
	}
	else
		error(0);
}

Phone::Phone(int n,string add,string card)
{
	if (checkNumber(n))
	{
		setNumber(n);
	}
	else
		error(0);
	setAddress(add);
	setCard(card);
}

void Phone::setNumber(int n)
{
	Number=n;
}

void Phone::setAddress(string add)
{
	Address=add;
}

void Phone::setCard(string card)
{
	Card=card;
}

bool Phone::checkNumber(int n)
{
	//先检测n的长度
	int len=1,tmp=0;
	while (n/10!=0)
	{
		n=n/10;
		len++;
		tmp++;
	}
	cout<<len;
    //如果不符合长度要求
	if (len==7 || len==11)
	{
		if (len==11)
		{
			n=n/10000;
		}
		return true;
	}

	return false;
}

int Phone::getNumber()
{
	return Number;
}

string Phone::getAddress()
{
	return Address;
}

string Phone::getCard()
{
	return Card;
}

void Phone::error(int e)
{
	if (e==0) cout<<endl<<"您所输入的号码格式不对!请检查!"<<endl;
	if (e==1) cout<<endl<<"抱歉~号码地址未知!"<<endl;
}

void Phone::show()
{
	cout<<"手机"<<Number<<endl<<"归属地:"<<Address<<endl<<"手机卡类型:"<<endl;
}


int main(int argc, char *argv[])
{
	int pNumber,fNumber=0;
	string fAddress;
	string fCard;
	ifstream input;
	input.open("PHData.dat");
	if (input.fail())
	{
		cout<<"文件打开错误!"<<endl<<"<缺少PHData.dat文件或文件被破坏!>"<<endl;
		system("pause");
		exit(1);
	}

	cout<<"手机号码或前7位:";
	cin>>pNumber;

	Phone P(pNumber);

	int i=0;

	while (pNumber!=fNumber)
	{
		input>>fNumber>>fAddress>>fCard;
		//cout<<i++<<endl<<fNumber<<" "<<fAddress<<" "<<fCard<<endl;
		//system("pause");
	}

	cout<<fAddress<<fCard;








	return 0;
}

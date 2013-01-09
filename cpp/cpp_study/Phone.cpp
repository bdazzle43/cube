#include <iostream>
#include <fstream>
#include <math.h>
using namespace std;



/***********�ֻ���***********/
class Phone
{
	private:
		int Number;    //�ֻ�����
		string Address,Card;    //�ֻ�������,������
	public:
		Phone(){}
		Phone(int);
		Phone(int,string,string);
		void setNumber(int );       //���ú���
	    bool checkNumber(int);     //������Ϸ���
		void setAddress(string );   //�����ֻ���ַ
		void setCard(string );      //�����ֻ�������
		int getNumber();            //��ȡ����
		string getAddress();        //��ȡ��ַ
		string getCard();           //��ȡ������
		void error(int );           //������ʾ
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
	//�ȼ��n�ĳ���
	int len=1,tmp=0;
	while (n/10!=0)
	{
		n=n/10;
		len++;
		tmp++;
	}
	cout<<len;
    //��������ϳ���Ҫ��
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
	if (e==0) cout<<endl<<"��������ĺ����ʽ����!����!"<<endl;
	if (e==1) cout<<endl<<"��Ǹ~�����ַδ֪!"<<endl;
}

void Phone::show()
{
	cout<<"�ֻ�"<<Number<<endl<<"������:"<<Address<<endl<<"�ֻ�������:"<<endl;
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
		cout<<"�ļ��򿪴���!"<<endl<<"<ȱ��PHData.dat�ļ����ļ����ƻ�!>"<<endl;
		system("pause");
		exit(1);
	}

	cout<<"�ֻ������ǰ7λ:";
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

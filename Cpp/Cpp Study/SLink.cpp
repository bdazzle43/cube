#include <iostream>
//#include <conio.h>   //����getch()
#include "SLink.h"
using namespace std;

/*-------------������--------------*/
SLink::~SLink()
{
	Node *p;

	while(!isEmpty())
	{
		p=head->next;
		delete head;
		head=p;
	}
}

void SLink::addNode(int info,int i)         //����ڵ�
{
	if (i>getLength()+1 || i<1)
	{
		return ;
	}
	Node *p;
	int j=1;
	for (p=head; j<i; j++)
	{
		p=p->next;
	}
	p->next=new Node(info,p->next);

}

void SLink::deleteNode(int i)            //ɾ���ڵ�
{
	if (i>getLength() || i<1)
	{
		return ;
	}
	Node *p,*tmp;
	int j=1;
	for (p=head; j<i; j++)
	{
		p=p->next;
	}
	tmp=p->next;
	p->next=tmp->next;
	delete tmp;
}

int SLink::isInList(int info)           //�ڵ����ݲ���
{
	Node *p;
	p=head->next;
	int i;
	for (i=1; i<=getLength(); i++)
	{
		if (p->data==info)
		{
			break;
		}
		p=p->next;
	}
	if (i>getLength())
	{
		return 0;
	}
	else
		return i;

}

int SLink::getLength()           //������
{
	int len=0;
	Node *p;
	for (p=head->next; p!=NULL; p=p->next)
	{
		len++;
	}
	return len;
}

void SLink::outLink()          //��ӡ����
{
	Node *p;
	int i=1;

	p=head->next;
	while(p!=NULL)
	{
		cout<<"*�ڵ�"<<i++<<": "<<p->data<<endl;
		p=p->next;
		cout<<endl;
	}

}

void SLink::text()               //���Ժ���
{
	head->data=12;
	cout<<head->data;
}

/*--------------���������---------------*/


int begin()
{
	int key;
	system("cls");
	cout<<"******�������ʵ��******\n";
	cout<<"       1.�쿴����\n";
	cout<<"       2.����ڵ�\n";
	cout<<"       3.ɾ���ڵ�\n";
	cout<<"       4.���ҽڵ�\n";
	cout<<"       5.�˳�"<<endl<<endl<<"ѡ��:";
	cin>>key;
	return key;
}

void fun_1(SLink &l)              //�쿴����
{
	cout<<endl;
	cout<<"������:"<<l.getLength()<<endl;
	l.outLink();
	cout<<endl;
	system("pause");
}

void fun_2(SLink &l)                 //����ڵ�
{
	int info,i;
	cout<<endl<<"����Ҫ���������:";
	cin>>info;
	cout<<"�����������еĵڼ�λ��"<<"(1~"<<l.getLength()+1<<")";
	cin>>i;
	l.addNode(info,i);
}

void fun_3(SLink &l)                  //ɾ���ڵ�
{
	int i;
	cout<<endl<<"ɾ���ڼ�λ�ڵ㣿"<<"(1~"<<l.getLength()<<")";
	cin>>i;
	l.deleteNode(i);
}

void fun_4(SLink &l)                     //���ҽڵ�
{
	int info;
	cout<<endl<<"����Ҫ���ҵ���Ϣ�Ƿ���������";
	cin>>info;
	if (l.isInList(info)==0)
	{
		cout<<"û���ҵ�"<<endl;
	}
	else
		cout<<endl<<info<<"�������е�"<<l.isInList(info)<<"λ"<<endl;
	system("pause");
}

void fun_5()
{
	exit(1);
}


int main()
{
	/*
	SLink l;
	l.addNode(1,1);
	l.addNode(3,2);
	l.addNode(5,1);
	l.outLink();
	//l.text();
	system("pause");
	return 0;
	*/


	SLink l;

	while(true)
	{
		switch (begin())
		{
			case 1:
				fun_1(l);
			break;

			case 2:
				fun_2(l);
			break;

			case 3:
				fun_3(l);
			break;

			case 4:
				fun_4(l);
			break;

			case 5:
				fun_5();
			break;
			default: cout<<"error";
		}
	}


	system("pause");
}

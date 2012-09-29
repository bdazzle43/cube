#include <iostream>
//#include <conio.h>   //用于getch()
#include "SLink.h"
using namespace std;

/*-------------链表类--------------*/
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

void SLink::addNode(int info,int i)         //插入节点
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

void SLink::deleteNode(int i)            //删除节点
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

int SLink::isInList(int info)           //节点数据查找
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

int SLink::getLength()           //链表长度
{
	int len=0;
	Node *p;
	for (p=head->next; p!=NULL; p=p->next)
	{
		len++;
	}
	return len;
}

void SLink::outLink()          //打印链表
{
	Node *p;
	int i=1;

	p=head->next;
	while(p!=NULL)
	{
		cout<<"*节点"<<i++<<": "<<p->data<<endl;
		p=p->next;
		cout<<endl;
	}

}

void SLink::text()               //测试函数
{
	head->data=12;
	cout<<head->data;
}

/*--------------链表类结束---------------*/


int begin()
{
	int key;
	system("cls");
	cout<<"******单链表的实现******\n";
	cout<<"       1.察看链表\n";
	cout<<"       2.插入节点\n";
	cout<<"       3.删除节点\n";
	cout<<"       4.查找节点\n";
	cout<<"       5.退出"<<endl<<endl<<"选择:";
	cin>>key;
	return key;
}

void fun_1(SLink &l)              //察看链表
{
	cout<<endl;
	cout<<"链表长度:"<<l.getLength()<<endl;
	l.outLink();
	cout<<endl;
	system("pause");
}

void fun_2(SLink &l)                 //插入节点
{
	int info,i;
	cout<<endl<<"输入要插入的数据:";
	cin>>info;
	cout<<"插入在链表中的第几位？"<<"(1~"<<l.getLength()+1<<")";
	cin>>i;
	l.addNode(info,i);
}

void fun_3(SLink &l)                  //删除节点
{
	int i;
	cout<<endl<<"删除第几位节点？"<<"(1~"<<l.getLength()<<")";
	cin>>i;
	l.deleteNode(i);
}

void fun_4(SLink &l)                     //查找节点
{
	int info;
	cout<<endl<<"输入要查找的信息是否在链表中";
	cin>>info;
	if (l.isInList(info)==0)
	{
		cout<<"没有找到"<<endl;
	}
	else
		cout<<endl<<info<<"在链表中第"<<l.isInList(info)<<"位"<<endl;
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

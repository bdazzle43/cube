//#include <iostream>
//using namespace std;

class Node
{
	public:
		int data;
	    Node *next;
		Node(){}
		Node(int info,Node *n=NULL)
	    {
			data=info;
			next=n;
		}
};
//µ¥Á´±í
class SLink
{
	private:
		Node *head;
	public:
		SLink()
		{
			head=new Node(0,NULL);
		}
	    ~SLink();
		bool isEmpty(){return (head->next==NULL);}
		void addNode(int info,int i);
		void deleteNode(int i);
		int isInList(int info);
		int getLength();
		void outLink();
		void text();
};

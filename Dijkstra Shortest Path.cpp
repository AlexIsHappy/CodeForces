#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
class node{
public:
	int val;
	int dis;
	int vis;
	int add;
	long int edist;
	node *next;
	node(int n, node *ptr, long int edist){
		val = n;
		this->edist = edist;
		dis = -1;
		vis = 0;
		add = 0;
		next = ptr;
	}
};

void breadth(node **adj, node *queue, node *last, long int *dist){
	if (queue != NULL){
		node *temp = adj[queue->val];
		while (temp != NULL){
			if (dist[temp->val] == -1 || dist[temp->val] > dist[queue->val] + temp->edist){
				dist[temp->val] = dist[queue->val] + temp->edist;
				node *ptr = new node(temp->val, NULL, 0);
				last->next = ptr;
				last = ptr;
			}
			temp = temp->next;
		}
		queue = queue->next;
		/*
		cout<<"queue\n";
		temp = queue;
		while(temp !=NULL){
		cout<<temp->val+1<<" ";
		temp = temp->next;
		}
		cout<<endl;
		*/
		breadth(adj, queue, last, dist);
	}
}



int main() {
	long int t;
	cin >> t;
	while (t--){
		long int n, m;
		cin >> n;
		node *adj[n];
		for (long int i = 0; i<n; i++){
			adj[i] = NULL;
		}
		cin >> m;
		for (long int i = 0; i<m; i++){
			long int x, y, z;
			cin >> x >> y >> z;
			node *ptr = new node(x - 1, adj[y - 1], z);
			adj[y - 1] = ptr;
			ptr = new node(y - 1, adj[x - 1], z);
			adj[x - 1] = ptr;
		}
		/* cout<<"printing queue"<<endl;
		for(long int i=0;i<n;i++){
		node *ptr = adj[i];
		while(ptr!=NULL){
		cout<<ptr->val+1<<" + " <<ptr->edist<<" ";
		ptr = ptr->next;
		}
		cout<<endl;
		}
		*/

		long int s;
		cin >> s;
		s = s - 1;



		node *queue, *last;
		node *ptr = new node(s, NULL, 0);
		long int dist[n];
		for (long int i = 0; i <= n; i++)
			dist[i] = -1;
		dist[s] = 0;
		queue = ptr;
		last = ptr;
		breadth(adj, queue, last, dist);
		for (long int i = 0; i<n; i++){
			if (i != s){
				cout << dist[i] << " ";
			}
		}
		cout << endl;
	}

	return 0;
}
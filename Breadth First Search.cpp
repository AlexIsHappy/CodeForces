#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <queue>
#include <map>

using namespace std;

// Graph class represents a directed graph using adjacency list representation
class Graph
{
	int V;    // No. of vertices
	vector<int> *adj;    // Pointer to an array containing adjacency lists
public:
	Graph(int V);   // Constructor
	void addEdge(int v, int w);   // function to add an edge to graph
	void showGraph();
	map<int, int> BFS(int s);
};

Graph::Graph(int V)
{
	this->V = V;
	adj = new vector<int>[V + 2];
}

void Graph::showGraph(){
	for (int i = 1; i <= V; i++){
		cout << "Vertex: " << i << " ";

		for (vector<int>::iterator it = adj[i].begin(); it != adj[i].end(); it++){
			cout << *it << " ";
		}
		cout << "\n";
	}
}

void Graph::addEdge(int v, int w)
{
	adj[v].push_back(w);
	adj[w].push_back(v);// Add w to v’s list.
}

map<int, int> Graph::BFS(int s){
	map<int, int> dist;

	queue<int> q;
	q.push(s);

	dist[s] = 0;

	while (!q.empty()){
		int v = q.front(); q.pop();
		vector<int>::iterator it;
		for (it = adj[v].begin(); it != adj[v].end(); it++){
			if (!dist.count(*it)){
				q.push(*it);
				dist[*it] = dist[v] + 1;
			}
		}
	}

	return dist;
}

int main() {
	int t; cin >> t;

	while (t--){
		int v, e; cin >> v >> e;

		Graph g(v);
		for (int i = 0; i < e; i++){
			int v, u; cin >> v >> u;

			g.addEdge(v, u);
		}

		// g.showGraph();
		int s; cin >> s;
		map<int, int> ans = g.BFS(s);

		for (int i = 1; i <= v; i++){
			bool isConnected = false;
			for (map<int, int>::iterator it = ans.begin(); it != ans.end(); it++){
				if (it->first == i){
					if (i == s)
						isConnected = true;
					else{
						cout << (it->second) * 6 << " ";
						isConnected = true;
						break;
					}
				}
			}


			if (!isConnected)
				cout << "-1" << " ";
		}
		cout << "\n";

	}

	return 0;
}
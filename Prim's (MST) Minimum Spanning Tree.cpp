#include <cstdio>
#include <cstdlib>
#include <cstring>
#include <cmath>
#include <iostream>
#include <sstream>
#include <vector>
#include <list>
#include <deque>
#include <queue>
#include <stack>
#include <set>
#include <map>
#include <utility>
#include <algorithm>
#include <limits>
#include <iomanip>
#include <bitset>
#include <string>

#define INF 1000000000
#define Inf 1000000000000000000
#define EPS 1e-9
#define ALL(X) (X).begin(), (X).end()
#define RI(X) scanf("%d", &(X))
#define RII(X, Y) scanf("%d%d", &(X), &(Y))
#define RIII(X, Y, Z) scanf("%d%d%d", &(X), &(Y), &(Z))
#define DRI(X) int (X); scanf("%d", &X)
#define DRII(X, Y) int X, Y; scanf("%d%d", &X, &Y)
#define DRIII(X, Y, Z) int X, Y, Z; scanf("%d%d%d", &X, &Y, &Z)
#define RS(X) scanf("%s", (X))
#define CASET int ___T, case_n = 1; scanf("%d ", &___T); while (___T-- > 0)
#define MP make_pair
#define PB push_back
#define MS0(X) memset((X), 0, sizeof((X)))
#define MS1(X) memset((X), -1, sizeof((X)))
#define LEN(X) strlen(X)
#define PLL pair<long long,long long>
#define VPLL vector<pair<long long,long long> >
#define F first
#define S second
#define forin for(int i = 0;i < n;i++)


#define REP(i, N) for (int i = 0; i < (N); ++i)
#define REPP(i, A, B) for (int i = (A); i < (B); ++i)
using namespace std;

typedef long long ll;

// Weighted Graph representation 
typedef pair<int, int> ii;  // Neighboring vertex and its weight
typedef vector<ii> vii;    // For each vertex we store vector of adjacent vertices
typedef vector<vii> vvii;  // Vector of V vertices

// Unweighted Graph representation
typedef vector<int> vi;    // For each vertex we store vector of adjacent vertices
typedef vector<vi> vvi;  // Vector of V vertices


// Graph class represents a directed graph using adjacency list representation
class Graph
{
	int V;    // No. of vertices
	vector<int> *adj;    // Pointer to an array containing adjacency lists
	void DFSUtil(int v, bool visited[]);  // A function used by DFS
	void DSPUtil(int s, bool visited[], int edgeTo[]);
public:
	Graph(int V);   // Constructor
	void addEdge(int v, int w);   // function to add an edge to graph
	void DFS(int v);    // DFS traversal of the vertices reachable from v
	void DSP(int s, int v);    // Depth Search Path from the source vertex
};

Graph::Graph(int V)
{
	this->V = V;
	adj = new vector<int>[V];
}

void Graph::addEdge(int v, int w)
{
	adj[v].push_back(w);
	adj[w].push_back(v);// Add w to v’s list.
}

void Graph::DFSUtil(int v, bool visited[])
{
	// Mark the current node as visited and print it
	visited[v] = true;
	cout << v << " ";

	// Recur for all the vertices adjacent to this vertex
	vector<int>::iterator i;
	for (i = adj[v].begin(); i != adj[v].end(); ++i)
		if (!visited[*i])
			DFSUtil(*i, visited);
}

// DFS traversal of the vertices reachable from v. It uses recursive DFSUtil()
void Graph::DFS(int v)
{
	// Mark all the vertices as not visited
	bool *visited = new bool[V];
	for (int i = 0; i < V; i++)
		visited[i] = false;

	// Call the recursive helper function to print DFS traversal
	DFSUtil(v, visited);
}

/* Weighted Graph */
class Edge{
	int v;
	int w;
public:
	double weight;
	Edge(int v, int w, double weight);
	int either(){ return v; }
	int other(int vertex){
		if (vertex == v) return w;
		else if (vertex == w) return v;
		return 0;
	}
	bool operator<(const Edge& other) const{
		return weight >= other.weight;
	}
};

Edge::Edge(int v, int w, double weight){
	this->v = v;
	this->w = w;
	this->weight = weight;
};


class EdgeWeightedGraph{
	int V;
	int E;
	vector<Edge> *adj;
public:
	EdgeWeightedGraph(int V);
	int v(){ return V; }
	int e(){ return E; }
	void addEdge(int v, int w, double weight);
	void addEdge(Edge e);
	vector<Edge> adjto(int v){ return adj[v]; }
};

EdgeWeightedGraph::EdgeWeightedGraph(int V){
	this->V = V;
	this->E = 0;
	adj = new vector<Edge>[V];
}

void EdgeWeightedGraph::addEdge(int v, int w, double weight){
	Edge e(v, w, weight);
	adj[v].push_back(e);
	adj[w].push_back(e);
}

void EdgeWeightedGraph::addEdge(Edge e){
	int v = e.either(); int w = e.other(v);
	adj[v].push_back(e);
	adj[w].push_back(e);
}


/* Trim's Algorithm Lasy Implementation */
class LazyPrim{
	bool *marked;
	queue<Edge> mst; // Mst edges
	priority_queue<Edge> pq; // Crossed and ineligible edges

public:
	LazyPrim(EdgeWeightedGraph G, int s);
	void visit(EdgeWeightedGraph G, int v);
	queue<Edge> edges(){ return mst; }
};

LazyPrim::LazyPrim(EdgeWeightedGraph G, int s){
	marked = new bool[G.v()];
	for (int i = 0; i < G.v(); i++){
		marked[i] = false;
	}

	visit(G, s);

	while (!pq.empty()){
		Edge e = pq.top(); pq.pop();

		int v = e.either(); int w = e.other(v);
		if (marked[v] && marked[w]) continue;
		mst.push(e);

		if (!marked[v]) visit(G, v);
		if (!marked[w]) visit(G, w);
	}
}

void LazyPrim::visit(EdgeWeightedGraph G, int v){
	marked[v] = true;
	//cout << "Current node:" << v << "\n";
	vector<Edge> adj = G.adjto(v);

	for (int i = 0; i < adj.size(); i++){
		if (!marked[adj[i].other(v)])
			pq.push(adj[i]);
	}

	/*for (vector<Edge>::iterator it = G.adjto(v).begin(); it != G.adjto(v).end(); it++){
	//if (!marked[(*it).other(v)]) pq.push(*it);
	}*/
}





int main(){

	int V, E; cin >> V >> E;

	EdgeWeightedGraph  g(V);

	for (int i = 0; i < E; i++){
		int v, w; double weight; cin >> v >> w >> weight;

		g.addEdge(v - 1, w - 1, weight);
	}

	// Starting point
	int s; cin >> s;
	s = s - 1;

	/*int V = 5; int E = 6;
	EdgeWeightedGraph  g(V);
	g.addEdge(0, 1, 3);
	g.addEdge(0, 2, 4);
	g.addEdge(3, 1, 6);
	g.addEdge(4, 1, 2);
	g.addEdge(1, 2, 5);
	g.addEdge(2, 4, 7);

	int s = 0;*/
	LazyPrim prim(g, s);

	queue<Edge> mst = prim.edges();

	long long count = 0;
	while (!mst.empty()){
		count += mst.front().weight;
		mst.pop();
	}

	cout << count;

	//------
	return 0;
}
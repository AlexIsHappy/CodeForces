#include <algorithm>
#include <iomanip>
#include <istream>
#include <map>
#include <numeric>
#include <ostream>
#include <set>
#include <sstream>
#include <string>
#include <utility>
#include <vector>
#include <queue>
using namespace std;
// Powered by caide (code generator, tester, and library code inliner)


vector<vector<int>> adj;
vector<int> vis;

int maxn = 1;

void dfs(int root, int d, std::istream& in, std::ostream& out){
	vis[root] = 1;


	for (int i = 0; i < adj[root].size(); i++){
		if (!vis[adj[root][i]]){
			dfs(adj[root][i], d + 1,in,out);
		}
	}

	if (d > maxn)
	{
		maxn = d;
	}
	//out << "Node: " << root << " lvl: " << d << "\n";
}

class Solution {
public:
    void solve(std::istream& in, std::ostream& out) {
		int n;
		in >> n;

		for (int i = 0; i < n; i++){
			vector<int> adjt;
			adj.push_back(adjt);
		}

		for (int i = 0; i < n; i++){
			vis.push_back(0);
		}

		vector<int> roots;
		for (int i = 0; i < n; i++){
			int c; in >> c;
			if (c == -1)
			{
				roots.push_back(i);
			}
			else{
				c--;
				adj[i].push_back(c);
				adj[c].push_back(i);
			}
		}


		for (int i = 0; i < roots.size(); i++){
			dfs(roots[i], 1, in, out);
		}

		out << maxn;
    }
};

void solve(std::istream& in, std::ostream& out)
{
    out << std::setprecision(12);
    Solution solution;
    solution.solve(in, out);
}

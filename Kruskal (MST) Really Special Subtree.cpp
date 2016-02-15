//Author : pakhandi
//
using namespace std;

#include<bits/stdc++.h>

#define wl(n) while(n--)
#define fl(i,a,b) for(i=a; i<b; i++)
#define rev(i,a,b) for(i=a; i>=b; i--)
#define scan(n) scanf("%d", &n)
#define scans(s) scanf("%s", s)
#define scanc(c) scanf("%c", &c)
#define scanp(f) scanf("%f", &f)
#define print(n) printf("%d\n", n)
#define prints(s) printf("%s\n", s)
#define printc(c) printf("%c\n", c)
#define printp(f) printf("%f\n", f)
#define nline printf("\n")
#define mclr(strn) strn.clear()
#define ignr cin.ignore()
#define MOD 1000000007
#define ll long long int
#define u64 unsigned long long int

#define PB push_back
#define SZ size
#define MP make_pair

int dist[3005], parent[3005];
bool vis[3005];

std::vector<int> adj[3003];

int mat[3005][3005];

queue<pair<int, int> > pro;

int n, e;

int main()
{
	int i, j;

	int cases;

	//scan(cases);

	//wl(cases)
	{
		cin >> n >> e;
		fl(i, 0, n + 1)
		{
			adj[i].clear();
			vis[i] = 0;
			parent[i] = -1;
			dist[i] = INT_MAX;

		}
		fl(i, 0, n + 1)
			fl(j, 0, n + 1)
		{
			mat[i][j] = INT_MAX;
			if (i == j)
				mat[i][j] = 0;
		}
		fl(i, 0, e)
		{
			int x, y;
			cin >> x >> y;
			adj[x].PB(y);
			adj[y].PB(x);
			int val;
			cin >> val;
			mat[x][y] = mat[y][x] = min(val, mat[x][y]);
		}
		int ini;
		cin >> ini;

		int node = ini;
		dist[node] = 0;
		vis[node] = 1;

		while (1)
		{


			fl(i, 0, n - 1)
			{
				int this_dist = INT_MAX;
				//Find the node with the minimum distance
				fl(j, 1, n + 1)
				{
					if (!vis[j] && dist[j]<this_dist)
					{
						this_dist = dist[j];
						node = j;
					}
				}

				//mark this node as visited
				vis[node] = 1;
				int limit = adj[node].SZ();

				fl(j, 0, limit)
				{
					if (!vis[adj[node][j]] && mat[node][adj[node][j]]<dist[adj[node][j]])
					{
						dist[adj[node][j]] = mat[node][adj[node][j]];
						parent[adj[node][j]] = node;
					}
				}

			}

			int f = 0;

			fl(i, 1, n + 1)
			{
				if (dist[i] == INT_MAX)
				{
					node = i;
					dist[node] = 0;
					vis[node] = 1;
					parent[node] = node;
					f = 1;
					break;

				}
			}
			if (f == 0)
				break;
		}

		ll ans = 0;
		fl(i, 1, n + 1)
		{
			if (i != ini && dist[i] != INT_MAX)
				ans += mat[i][parent[i]];
		}
		cout << ans;
		nline;



	}

	return 0;
}
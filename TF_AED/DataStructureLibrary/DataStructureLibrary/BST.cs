using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary
{
    /// <summary>
    /// Classe para uma ávore binária de busca - binary search tree (BST). Contém métodos virtuais da estrutura e pode ser herdada em uma estrutura de dados
    /// </summary>
    class BST
    {
        private Node root; //raiz da ávore. 
        private int count;

        public BST()
        {
            this.root = null;
            this.count = 0;
        }

        /// <summary>
        /// Adiciona um objeto na árvore de busca binária
        /// </summary>
        /// <param name="obj">Objeto do tipo 'Data'</param>
        public void Add(Data obj)
        {
            if (this.Empty())
            {
                this.root = new Node(obj);
            }
            else
            {
                Node _new = new Node(obj);
                this.Add(this.root, _new);
            }
            this.count++;
        }
        private void Add(Node root, Node node)
        {
            if (node.CompareTo(root) < 0)
            {
                if (root.Left == null)
                {
                    root.Left = node;
                }
                else this.Add(root.Left, node);
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = node;
                }
                else this.Add(root.Right, node);
            }

        }

        /// <summary>
        /// Encontrar um objeto 'Obj' na ávore de busca binária.
        /// </summary>
        /// <param name="Obj">Objeto Data</param>
        /// <returns>Se o 'Obj' existir, o mesmo é retonardo da atual instância; caso contrário, é retornado 'null'</returns>
        public bool Find (Data obj)
        {
            if (!Empty())
            {
                return Find(this.root, obj);
            }
            else return false;
            
        }

        private bool Find(Node root, Data obj)
        {
            if (root == null) return false;
            if (root.Data.Equals(obj)) return true;
            if (obj.CompareTo(root.Data) < 0) return this.Find(root.Left, obj);
            else return this.Find(root.Right, obj);
        }

        public bool Empty()
        {
            return root == null;
        }
        /// <summary>
        /// Retorna os objetos na árvore binária de busca em-ordem.
        /// </summary>
        /// <returns>Os objetos na árvore binária de busca em-ordem.</returns>
        public override string ToString()
        {
            StringBuilder _retun = new StringBuilder();
            this.LevelOrder(this.root, ref _retun);
            return _retun.ToString();
        }

        private void LevelOrder(Node root, ref StringBuilder _return) // retorna (imprime) a ávore em-ordem.
        {
            if (root == null) return;
            LevelOrder(root.Left, ref _return);
            _return.AppendFormat(root.Data.ToString());
            LevelOrder(root.Right, ref _return);
        }
    }
}

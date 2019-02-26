using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLibrary
{
    /// <summary>
    /// Classe para uma fila, contém métodos virtuais da estrutura e pode ser herdada em uma estrutura de dados
    /// </summary>
    public class Queue
    {
        private Element first, last;
        int count;

        /// <summary>
        /// Inicializa uma nova instância de fila duplamente encadeada que está vazia e tem a capacidade inicial padrão.
        /// </summary>
        public Queue()
        {
            this.first = new Element(null); //sentinela, o primeiro elemento é nulo.
            this.last = this.first; // A fila está vazia, logo, o primeiro e o último aponta para o nulo (o mesmo endereço de memória)
            count = 0; //fila vazia
        }
        public int Count { get => count; }
        protected Element First { get => first; set => first = value; }
        protected Element Last { get => last; set => last = value; }

        /// <summary>
        /// Remove todos os elementos da atual instância.
        /// </summary>
        public void Clear()
        {
            this.first = new Element(null); //sentinela, o primeiro elemento é nulo.
            this.last = this.first; // A fila está vazia, logo, o primeiro e o último aponta para o nulo (o mesmo endereço de memória)
            count = 0; //fila vazia
        }

        /// <summary>
        /// Adicionar um objeto no final da fila.
        /// </summary>
        /// <param name="Obj">Objeto Data.</param>
        public virtual void Enqueue(Data Obj)
        {
            if (Obj != null)
            {
                this.last.next = new Element(Obj);
                this.last.next.previous = this.last;
                this.last = this.last.next;
                this.count++;
            }
            else throw new ArgumentException("O parâmetro é nulo", "Obj");

        }
        /// <summary>
        /// Remove e retorna o objeto do início da fila.
        /// </summary>
        /// <returns>Se a atual instância não estiver vázia, o primeiro objeto é removido da atual instância e retonardo; caso contrário, é retornado 'null'</returns>
        public virtual Data Dequeue()
        {
            if (!this.Empty())
            {
                Element aux = this.first.next;

                if (aux != this.last)
                {
                    aux.previous.next = aux.next;
                    aux.next.previous = aux.previous;
                    count--; // atualiza a quantidade de elementos da fila
                }
                else
                { 
                    this.Clear();
                }
                aux.next = aux.previous = null;
                return aux.Data;

            }
            return null;
        }

        /// <summary>
        /// Retorna o primeiro objeto da fila sem removê-lo.
        /// </summary>
        /// <returns>Se a atual instância não estiver vázia, o último objeto é retornado da atual instância; caso contrário, é retornado 'null'</returns>
        public virtual Data Peek()
        {
            if (!this.Empty())
            {
                Element aux = new Element(this.first.next.Data);
                return aux.Data;
            }
            return null;
        }

        /// <summary>
        /// Indica se a atual instância está vazia ou não.
        /// </summary>
        /// <returns>True se a atual instância estiver vazia; caso contrário, False.</returns>
        public bool Empty()
        {
            return (this.first == this.last);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retorna uma cadeia de caracteres que representa o objeto atual</returns>
        public override string ToString()
        {
            Element aux = this.first.next;
            StringBuilder _return = new StringBuilder();
            while (aux != null)
            {
                _return.AppendFormat(aux.Data.ToString());
                aux = aux.next;
            }
            return _return.ToString();
        }
    }
}

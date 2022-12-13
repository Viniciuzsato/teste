﻿using TesteTecnico.Entity;
using TesteTecnico.Repository.Interface;
using TesteTecnico.Service.Interface;

namespace TesteTecnico.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService( IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public void Adicionar(Produto produto)
        {
            if (produto is not null)
                _produtoRepository.Adicionar(produto);
        }

        public void Alterar(Produto produto)
        {
            if (produto is not null)
                _produtoRepository.Alterar(produto);
        }

        public void Deletar(Produto produto)
        {
                _produtoRepository.Deletar(produto);
        }

        public List<Produto> Obter()
        {
            throw new NotImplementedException();
        }

        public Produto ObterPorId(int produtoId)
        {
            throw new NotImplementedException();
        }
    }
}

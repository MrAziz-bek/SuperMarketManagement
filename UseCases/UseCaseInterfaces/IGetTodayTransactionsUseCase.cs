﻿using CoreBusiness;

namespace UseCases;
public interface IGetTodayTransactionsUseCase
{
    IEnumerable<Transaction> Execute(string cashierName);
}
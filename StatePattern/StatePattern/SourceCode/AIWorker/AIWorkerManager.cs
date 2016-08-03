using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace StatePattern
{
    public class AIWorkerManager
    {
        static object _lockObj = new object();

        bool _isStarted = false;
        bool _isReserveStopThread = false;

        List<AIWorker> _aiWorkerList = new List<AIWorker>();

        static AIWorkerManager _instance = null;
        public static AIWorkerManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new AIWorkerManager();
                        }
                    }

                }

                return _instance;
            }
        }

        public void Start()
        {
            if (_isStarted == true)
                return;

            _isStarted = true;

            Thread aiWorkThread = new Thread(new ThreadStart(AIWorkThread));
            aiWorkThread.Start();
        }

        public void Stop()
        {
            if (_isStarted == false)
                return;

            _isReserveStopThread = true;
        }

        public void AIWorkThread()   
        {
            while (_isReserveStopThread == false)
            {
                for (int index = 0; index < _aiWorkerList.Count; ++index)
                {
                    if (_aiWorkerList[index].IsStopAIWorker() == true)
                    {
                        _aiWorkerList.RemoveAt(index--);
                        continue;
                    }

                    _aiWorkerList[index].AIWork();
                }

                Thread.Sleep(1000);
            }

            _isStarted = false;
            _isReserveStopThread = false;
        }

        public void AddAIWoker(AIWorker aiWorker)
        {
            if (aiWorker == null)
                return;
            
            _aiWorkerList.Add(aiWorker);
        }
    }
}


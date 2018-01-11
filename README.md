# RxUI8
Testing ReactiveUI8 with Xamarin Forms.


I'm getting an NullReferenceException when my app's bootstraper do new RoutedViewHost with the following stacktrace:
```
  at ReactiveUI.XamForms.RoutedViewHost+<>c__DisplayClass4_1.<.ctor>b__16 () [0x0001b] in <e2e0893758b346d587fba808f8b643f4>:0 
  at System.Reactive.Linq.ObservableImpl.Finally`1+_+<>c__DisplayClass2_0[TSource].<Run>b__0 () [0x0000d] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Disposables.AnonymousDisposable.Dispose () [0x00010] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Disposables.SingleAssignmentDisposable.Dispose () [0x00014] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Sink`1[TSource].Dispose () [0x0001d] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Disposables.SingleAssignmentDisposable.Dispose () [0x00014] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Disposables.StableCompositeDisposable+Binary.Dispose () [0x00010] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Disposables.SingleAssignmentDisposable.Dispose () [0x00014] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Disposables.CompositeDisposable.Dispose () [0x00060] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Disposables.SingleAssignmentDisposable.Dispose () [0x00014] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Sink`1[TSource].Dispose () [0x0001d] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Disposables.SingleAssignmentDisposable.Dispose () [0x00014] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Disposables.StableCompositeDisposable+Binary.Dispose () [0x00010] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.AnonymousSafeObserver`1[T].OnError (System.Exception error) [0x0001c] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Linq.ObservableImpl.SelectMany`2+_+Iter[TSource,TResult].OnError (System.Exception error) [0x00016] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Linq.ObservableImpl.Finally`1+_[TSource].OnError (System.Exception error) [0x00000] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Linq.ObservableImpl.SelectMany`2+_+Iter[TSource,TResult].OnError (System.Exception error) [0x00016] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Linq.ObservableImpl.Throw`1+_[TResult].Invoke () [0x00000] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Concurrency.Scheduler.Invoke (System.Reactive.Concurrency.IScheduler scheduler, System.Action action) [0x00000] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Concurrency.ImmediateScheduler.Schedule[TState] (TState state, System.Func`3[T1,T2,TResult] action) [0x00014] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Concurrency.Scheduler.Schedule (System.Reactive.Concurrency.IScheduler scheduler, System.Action action) [0x0001c] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Linq.ObservableImpl.Throw`1+_[TResult].Run () [0x00000] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Linq.ObservableImpl.Throw`1[TResult].Run (System.IObserver`1[T] observer, System.IDisposable cancel, System.Action`1[T] setSink) [0x00010] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Producer`1[TSource].SubscribeRaw (System.IObserver`1[T] observer, System.Boolean enableSafeguard) [0x00071] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.ObservableExtensions.SubscribeSafe[T] (System.IObservable`1[T] source, System.IObserver`1[T] observer) [0x00036] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Linq.ObservableImpl.SelectMany`2+_[TSource,TResult].SubscribeInner (System.IObservable`1[T] inner) [0x0001b] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Linq.ObservableImpl.SelectMany`2+_[TSource,TResult].OnNext (TSource value) [0x0004a] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Linq.ObservableImpl.Select`2+_[TSource,TResult].OnNext (TSource value) [0x00033] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Linq.ObservableImpl.ToObservable`1+_[TSource].LoopRec (System.Reactive.Linq.ObservableImpl.ToObservable`1+_+State[TSource] state, System.Action`1[T] recurse) [0x0008b] in <e9c1ccec51844dbd92b833a0b4bc960e>:0 
  at System.Reactive.Concurrency.Scheduler+<>c__DisplayClass49_0`1[TState].<InvokeRec1>b__0 (TState state1) [0x0001e] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Concurrency.Scheduler.InvokeRec1[TState] (System.Reactive.Concurrency.IScheduler scheduler, System.Reactive.Concurrency.Scheduler+Pair`2[T1,T2] pair) [0x0004a] in <99f8205c51c44bb480747b577b8001ff>:0 
  at (wrapper delegate-invoke) System.Func`3[System.Reactive.Concurrency.IScheduler,System.Reactive.Concurrency.Scheduler+Pair`2[System.Reactive.Linq.ObservableImpl.ToObservable`1+_+State[ReactiveUI.IRoutableViewModel],System.Action`2[System.Reactive.Linq.ObservableImpl.ToObservable`1+_+State[ReactiveUI.IRoutableViewModel],System.Action`1[System.Reactive.Linq.ObservableImpl.ToObservable`1+_+State[ReactiveUI.IRoutableViewModel]]]],System.IDisposable]:invoke_TResult_T1_T2 (System.Reactive.Concurrency.IScheduler,System.Reactive.Concurrency.Scheduler/Pair`2<System.Reactive.Linq.ObservableImpl.ToObservable`1/_/State<ReactiveUI.IRoutableViewModel>, System.Action`2<System.Reactive.Linq.ObservableImpl.ToObservable`1/_/State<ReactiveUI.IRoutableViewModel>, System.Action`1<System.Reactive.Linq.ObservableImpl.ToObservable`1/_/State<ReactiveUI.IRoutableViewModel>>>>)
  at System.Reactive.Concurrency.ScheduledItem`2[TAbsolute,TValue].InvokeCore () [0x00000] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Concurrency.ScheduledItem`1[TAbsolute].Invoke () [0x0000d] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Concurrency.CurrentThreadScheduler+Trampoline.Run (System.Reactive.Concurrency.SchedulerQueue`1[TAbsolute] queue) [0x00040] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Concurrency.CurrentThreadScheduler.Schedule[TState] (TState state, System.TimeSpan dueTime, System.Func`3[T1,T2,TResult] action) [0x00046] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Concurrency.LocalScheduler.Schedule[TState] (TState state, System.Func`3[T1,T2,TResult] action) [0x0000e] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Producer`1[TSource].SubscribeRaw (System.IObserver`1[T] observer, System.Boolean enableSafeguard) [0x0005c] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.Reactive.Producer`1[TSource].Subscribe (System.IObserver`1[T] observer) [0x0000e] in <99f8205c51c44bb480747b577b8001ff>:0 
  at System.ObservableExtensions.Subscribe[T] (System.IObservable`1[T] source) [0x00023] in <99f8205c51c44bb480747b577b8001ff>:0 
  at ReactiveUI.XamForms.RoutedViewHost..ctor () [0x0008f] in <e2e0893758b346d587fba808f8b643f4>:0 
  at RxUI8.AppBootstrapper.CreateMainPage () [0x00002] in C:\v\RxUI8\RxUI8\RxUI8\RxUI8\AppBootstrapper.cs:30 
  
  ```

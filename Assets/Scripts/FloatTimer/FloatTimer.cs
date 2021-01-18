using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatTimer : MonoBehaviour
{
   // common implementation: will lose precision over time as time increases

   //float time = 0;
   //const float duration = 1;

   //void StartTimer()
   //{
   //   time = Time.time;
   //}

   //bool HasElapsed()
   //{
   //   return Time.time - time > duration;
   //}


   // test to see precision loss
   //const 
   float DELTA_TIME = 1 / 60f;
   void Start()
   {
      float time = 0;   // Time.time
      float elapsed = 0;

      print("Begin Time: " + time);
      print("Begin Elapsed: " + elapsed);
      print("Begin Delta Time: " + DELTA_TIME);

      do
      {
         float startTime = time;
         time += DELTA_TIME;   // wait 1 frame
         elapsed = time - startTime;
      } while (Mathf.Approximately(elapsed, DELTA_TIME));

      // elapsed and DELTA_TIME have diverged
      print("End Time: " + time);
      print("End Elapsed: " + elapsed);
      print("End Delta Time: " + DELTA_TIME);
   }


   // optimized implementation: maintain precision:

   //float elapsedTime = 0;

   //void StartTimer()
   //{
   //   elapsedTime = 0;
   //}

   //bool HasElapsed()
   //{
   //   const float duration = 1;
   //   return elapsedTime > duration;
   //}

   //void Update()
   //{
   //   // stays small, fewer rounding errors over time
   //   elapsedTime += Time.deltaTime;
   //}
}

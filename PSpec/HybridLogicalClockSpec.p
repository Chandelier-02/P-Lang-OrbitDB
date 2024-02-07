spec TimestampsAreMonotonicallyIncreasing observes eGetNowResp, eUpdateHlcResp {
    start state Init {
        on eGetNowResp do (resp: tGetNowResp) {
            assert resp.comparisonToPrevious == 1, 
            format("Timestamps are not monotonically increasing.");
        }

        on eUpdateHlcResp do (resp: tUpdateHlcResp) {
            assert resp.comparisonToPrevious == 1,
            format("Timestamps are not monotonically increasing.");
        }
    }
}
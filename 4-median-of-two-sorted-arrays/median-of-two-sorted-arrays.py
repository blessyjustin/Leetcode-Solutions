class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        if (len(nums1)>len(nums2)):
            return self.findMedianSortedArrays(nums2,nums1)
        m=len(nums1)
        n=len(nums2)
        tl=(m+n+1)//2
        
        start=0
        end=m
        while(start<=end):
            partx=(start+end)//2
            party=tl-partx

            leftx= float ('-inf') if partx==0 else nums1[partx-1]
            lefty=float ('-inf') if party==0 else nums2[party-1]
            rightx=float ('inf') if partx==m else nums1[partx]
            righty=float ('inf') if party==n else nums2[party]

            if leftx<=righty and lefty<=rightx:
                if((m+n)%2==0):
                    return (max(leftx,lefty)+min(rightx,righty))/2
                else:
                    return max(leftx,lefty)
            elif leftx>righty:
                end=partx-1
            else:
                start=partx+1

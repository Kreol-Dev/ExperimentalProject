namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Place AddContext10 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext10 ContextSwitchInterpreter
								if(AddContext10 != null)
								{
									System.Single OperandVar12 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop11 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar12 = prop11;
									AddContext10.Size = (System.Int32)( (OperandVar12));
								}
							}
							Named AddContext13 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext13 ContextSwitchInterpreter
								if(AddContext13 != null)
								{
									
									
									
									AddContext13.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar16 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar14 = default(System.String); //IsContext = False IsNew = False
									OperandVar14 = "human_name";
									System.String prop15 = External.RandomName( (OperandVar14)); //IsContext = False IsNew = False
									if(prop15 != null)
									{
										OperandVar16 = prop15;
									}
									AddContext13.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar16)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar18 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable17 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable17 != null)
						{
							OperandVar18 = StoredVariable17;
						}
						subContext5.Attach((Place)( (OperandVar18)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar32 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable19 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable19 != null)
			{
				Markers StoredVariable20 = ((Markers)StoredVariable19.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable20 != null)
				{
					System.Boolean ifResult21; //IsContext = False IsNew = False
					
					System.Boolean OperandVar28 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable19 != null)
					{
						UnityEngine.GameObject prop22 = StoredVariable19.ShowedObject; //IsContext = False IsNew = False
						if(prop22 != null)
						{
							System.Boolean ifResult23; //IsContext = False IsNew = False
							System.Boolean OperandVar27 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar25 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable24 = ((Named)prop22.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable24 != null)
							{
								OperandVar25 = StoredVariable24;
							}
							System.Boolean prop26 = External.Has( (OperandVar25)); //IsContext = False IsNew = False
							OperandVar27 = prop26;
							if(ifResult23 =  (OperandVar27))
							{
								OperandVar28 = ifResult23;
							}
						}
					}
					
					System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar29 = default(System.String); //IsContext = False IsNew = False
					OperandVar29 = "named_ui_marker";
					System.Boolean prop30 = StoredVariable20.HasMarker( (OperandVar29)); //IsContext = False IsNew = False
					OperandVar31 = prop30;
					if(ifResult21 = ( ( (OperandVar28))) && ( (!(OperandVar31))))
					{
						applicable = true;
						OperandVar32 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar32);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext33 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext33 ContextSwitchInterpreter
				if(subContext33 != null)
				{
					System.String OperandVar34 = default(System.String); //IsContext = False IsNew = False
					OperandVar34 = "named_ui_marker";
					subContext33.SetUiMarker(( (OperandVar34)).ToString());
				}
			}
			
			{
				UiObject subContext35 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext35 ContextSwitchInterpreter
				if(subContext35 != null)
				{
					Named OperandVar38 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop36 = subContext35.ShowedObject; //IsContext = False IsNew = False
					if(prop36 != null)
					{
						Named StoredVariable37 = ((Named)prop36.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable37 != null)
						{
							OperandVar38 = StoredVariable37;
						}
					}
					Named showed_named =  (OperandVar38); //IsContext = False IsNew = False
					TextField ContextVar39 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar39 ContextSwitchInterpreter
						if(ContextVar39 != null)
						{
							System.String OperandVar41 = default(System.String); //IsContext = False IsNew = False
							System.String prop40 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop40 != null)
							{
								OperandVar41 = prop40;
							}
							ContextVar39.Show(( (OperandVar41)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda42 = () => 
									{
										System.String OperandVar44 = default(System.String); //IsContext = False IsNew = False
										System.String prop43 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop43 != null)
										{
											OperandVar44 = prop43;
										}
										ContextVar39.Show(( (OperandVar44)).ToString());
									};
									showed_named.OnUpdate(Lambda42);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext45 = ContextVar39.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext45 ContextPropertySwitchInterpreter
								if(subContext45 != null)
								{
									
									subContext45.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar46 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar46 != null) EntVar46.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class place_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar60 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable47 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable47 != null)
			{
				UiObject StoredVariable48 = ((UiObject)StoredVariable47.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
				if(StoredVariable48 != null)
				{
					System.Boolean ifResult49; //IsContext = False IsNew = False
					
					System.Boolean OperandVar56 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop50 = StoredVariable48.ShowedObject; //IsContext = False IsNew = False
					if(prop50 != null)
					{
						System.Boolean ifResult51; //IsContext = False IsNew = False
						System.Boolean OperandVar55 = default(System.Boolean); //IsContext = False IsNew = False
						Place OperandVar53 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable52 = ((Place)prop50.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable52 != null)
						{
							OperandVar53 = StoredVariable52;
						}
						System.Boolean prop54 = External.Has( (OperandVar53)); //IsContext = False IsNew = False
						OperandVar55 = prop54;
						if(ifResult51 =  (OperandVar55))
						{
							OperandVar56 = ifResult51;
						}
					}
					
					System.Boolean OperandVar59 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar57 = default(System.String); //IsContext = False IsNew = False
					OperandVar57 = "place_ui_set";
					System.Boolean prop58 = StoredVariable47.HasMarker( (OperandVar57)); //IsContext = False IsNew = False
					OperandVar59 = prop58;
					if(ifResult49 = ( ( (OperandVar56))) && ( (!(OperandVar59))))
					{
						applicable = true;
						OperandVar60 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar60);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext61 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext61 ContextSwitchInterpreter
				if(subContext61 != null)
				{
					System.String OperandVar62 = default(System.String); //IsContext = False IsNew = False
					OperandVar62 = "place_ui_set";
					subContext61.SetUiMarker(( (OperandVar62)).ToString());
				}
			}
			
			{
				UiObject subContext63 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext63 ContextSwitchInterpreter
				if(subContext63 != null)
				{
					Place OperandVar66 = default(Place); //IsContext = False IsNew = False
					UnityEngine.GameObject prop64 = subContext63.ShowedObject; //IsContext = False IsNew = False
					if(prop64 != null)
					{
						Place StoredVariable65 = ((Place)prop64.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable65 != null)
						{
							OperandVar66 = StoredVariable65;
						}
					}
					Place pl =  (OperandVar66); //IsContext = False IsNew = False
					Blackboards.place_ui_data puidata = root.AddComponent<Blackboards.place_ui_data>();; //IsContext = False IsNew = True
					Entity EntVar67 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					
					
					{
						//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
						if(puidata != null)
						{
							System.Int32 OperandVar69 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop68 = pl.Size; //IsContext = False IsNew = False
							OperandVar69 = prop68;
							puidata.LastSize = (System.Int32)( (OperandVar69));
						}
					}
					TextField ContextVar70 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar70 ContextSwitchInterpreter
						if(ContextVar70 != null)
						{
							System.Int32 OperandVar72 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop71 = pl.Size; //IsContext = False IsNew = False
							OperandVar72 = prop71;
							ContextVar70.Show(( (OperandVar72)).ToString());
							System.Boolean OperandVar76 = default(System.Boolean); //IsContext = False IsNew = False
							Updated OperandVar74 = default(Updated); //IsContext = False IsNew = False
							Updated StoredVariable73 = ((Updated)ContextVar70.GetComponent(typeof(Updated))); //IsContext = False IsNew = False
							if(StoredVariable73 != null)
							{
								OperandVar74 = StoredVariable73;
							}
							System.Boolean prop75 = External.Has( (OperandVar74)); //IsContext = False IsNew = False
							OperandVar76 = prop75;
							if(!(OperandVar76))
							{
								root.AddComponent<Updated>();
								
							}
							
							{
								//ContextStatement TextField ContextVar70 ContextSwitchInterpreter
								if(ContextVar70 != null)
								{
									
									ContextVar70.Label = (System.String)( ("size"));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext77 = ContextVar70.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext77 ContextPropertySwitchInterpreter
								if(subContext77 != null)
								{
									
									subContext77.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								Updated subContext78 = (Updated)root.GetComponent(typeof(Updated)); //IsContext = True IsNew = False
								//ContextStatement Updated subContext78 ContextSwitchInterpreter
								if(subContext78 != null)
								{
									BoolDelegate Lambda79 = () => 
									{
										System.Boolean return_value = default(System.Boolean); //IsContext = False IsNew = False
										
										{
											//ContextStatement Place pl ContextSwitchInterpreter
											if(pl != null)
											{
												
												{
													//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
													if(puidata != null)
													{
														
														
														System.Int32 OperandVar81 = default(System.Int32); //IsContext = False IsNew = False
														if(pl != null)
														{
															System.Int32 prop80 = pl.Size; //IsContext = False IsNew = False
															OperandVar81 = prop80;
														}
														
														System.Int32 OperandVar83 = default(System.Int32); //IsContext = False IsNew = False
														if(puidata != null)
														{
															System.Int32 prop82 = puidata.LastSize; //IsContext = False IsNew = False
															OperandVar83 = prop82;
														}
														if(!(( ( (OperandVar81))) == ( ( (OperandVar83)))))
														{
															System.Int32 OperandVar85 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop84 = pl.Size; //IsContext = False IsNew = False
																OperandVar85 = prop84;
															}
															puidata.LastSize = (System.Int32)( (OperandVar85));
															System.Int32 OperandVar87 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop86 = pl.Size; //IsContext = False IsNew = False
																OperandVar87 = prop86;
															}
															ContextVar70.Show(( (OperandVar87)).ToString());
														}
													}
												}
											}
										}
										return return_value;
									};
									subContext78.OnUpdate(Lambda79);
								}
							}
						}
					}
					if(EntVar67 != null) EntVar67.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar96 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable88 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable88 != null)
			{
				Place StoredVariable89 = ((Place)StoredVariable88.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable89 != null)
				{
					System.Boolean ifResult90; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar92 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop91 = StoredVariable89.Agents; //IsContext = False IsNew = False
					if(prop91 != null)
					{
						OperandVar92 = prop91;
					}
					
					
					
					System.Boolean OperandVar95 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar93 = default(System.String); //IsContext = False IsNew = False
					OperandVar93 = "agents_pool";
					System.Boolean prop94 = StoredVariable88.HasMarker( (OperandVar93)); //IsContext = False IsNew = False
					OperandVar95 = prop94;
					if(ifResult90 = ( (( ( (OperandVar92 != null ? OperandVar92.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar95))))
					{
						applicable = true;
						OperandVar96 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar96);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext97 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext97 ContextSwitchInterpreter
				if(subContext97 != null)
				{
					
					subContext97.Size = (System.Int32)( (5f));
					System.Single OperandVar99 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop98 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar99 = prop98;
					for (int i = 0; i <  (OperandVar99); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag100 = ag; //IsContext = True IsNew = False
							Entity AddContext101 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext102 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext103 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext103 ContextSwitchInterpreter
								if(AddContext103 != null)
								{
									System.Single OperandVar105 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop104 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar105 = prop104;
									AddContext103.Age = (System.Int32)( (OperandVar105));
								}
							}
							Named AddContext106 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext106 ContextSwitchInterpreter
								if(AddContext106 != null)
								{
									
									
									
									AddContext106.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar109 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar107 = default(System.String); //IsContext = False IsNew = False
									OperandVar107 = "human_name";
									System.String prop108 = External.RandomName( (OperandVar107)); //IsContext = False IsNew = False
									if(prop108 != null)
									{
										OperandVar109 = prop108;
									}
									AddContext106.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar109)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar111 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable110 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable110 != null)
						{
							OperandVar111 = StoredVariable110;
						}
						subContext97.Attach((Agent)( (OperandVar111)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar118 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable112 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable112 != null)
			{
				System.Boolean ifResult113; //IsContext = False IsNew = False
				System.Boolean OperandVar117 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar115 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable114 = ((Blackboards.event_marker)StoredVariable112.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable114 != null)
				{
					OperandVar115 = StoredVariable114;
				}
				System.Boolean prop116 = External.Has( (OperandVar115)); //IsContext = False IsNew = False
				OperandVar117 = prop116;
				if(ifResult113 = !(OperandVar117))
				{
					applicable = true;
					OperandVar118 = applicable;
				}
			}
			return (System.Boolean) (OperandVar118);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar119 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar119 != null) EntVar119.ComponentAdded();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar126 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable120 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable120 != null)
			{
				System.Boolean ifResult121; //IsContext = False IsNew = False
				System.Boolean OperandVar125 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar123 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable122 = ((Blackboards.personality)StoredVariable120.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable122 != null)
				{
					OperandVar123 = StoredVariable122;
				}
				System.Boolean prop124 = External.Has( (OperandVar123)); //IsContext = False IsNew = False
				OperandVar125 = prop124;
				if(ifResult121 = !(OperandVar125))
				{
					applicable = true;
					OperandVar126 = applicable;
				}
			}
			return (System.Boolean) (OperandVar126);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar127 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar127 != null) EntVar127.ComponentAdded();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar134 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable128 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable128 != null)
			{
				System.Boolean ifResult129; //IsContext = False IsNew = False
				System.Boolean OperandVar133 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar131 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable130 = ((Blackboards.aged_generation)StoredVariable128.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable130 != null)
				{
					OperandVar131 = StoredVariable130;
				}
				System.Boolean prop132 = External.Has( (OperandVar131)); //IsContext = False IsNew = False
				OperandVar133 = prop132;
				if(ifResult129 = !(OperandVar133))
				{
					applicable = true;
					OperandVar134 = applicable;
				}
			}
			return (System.Boolean) (OperandVar134);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar135 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar135 != null) EntVar135.ComponentAdded();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar145 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable136 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable136 != null)
			{
				Lore StoredVariable137 = ((Lore)StoredVariable136.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable137 != null)
				{
					Place StoredVariable138 = ((Place)StoredVariable137.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable138 != null)
					{
						System.Boolean ifResult139; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar141 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop140 = StoredVariable138.Agents; //IsContext = False IsNew = False
						if(prop140 != null)
						{
							OperandVar141 = prop140;
						}
						
						
						
						System.Boolean OperandVar144 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar142 = default(System.String); //IsContext = False IsNew = False
						OperandVar142 = "lore_pool";
						System.Boolean prop143 = StoredVariable136.HasMarker( (OperandVar142)); //IsContext = False IsNew = False
						OperandVar144 = prop143;
						if(ifResult139 = ( (( ( (OperandVar141 != null ? OperandVar141.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar144))))
						{
							applicable = true;
							OperandVar145 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar145);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext146 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext146 ContextSwitchInterpreter
				if(subContext146 != null)
				{
					
					subContext146.Size = (System.Int32)( (10f));
					System.Single OperandVar148 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop147 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar148 = prop147;
					for (int i = 0; i <  (OperandVar148); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag149 = old_ag; //IsContext = True IsNew = False
							Entity AddContext150 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext151 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext152 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext153 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext153 ContextSwitchInterpreter
								if(AddContext153 != null)
								{
									System.Single OperandVar155 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop154 = External.Random( (30f), (45f)); //IsContext = False IsNew = False
									OperandVar155 = prop154;
									AddContext153.Age = (System.Int32)( (OperandVar155));
								}
							}
							Named AddContext156 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext156 ContextSwitchInterpreter
								if(AddContext156 != null)
								{
									
									
									
									AddContext156.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar159 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar157 = default(System.String); //IsContext = False IsNew = False
									OperandVar157 = "human_name";
									System.String prop158 = External.RandomName( (OperandVar157)); //IsContext = False IsNew = False
									if(prop158 != null)
									{
										OperandVar159 = prop158;
									}
									AddContext156.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar159)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar161 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable160 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable160 != null)
						{
							OperandVar161 = StoredVariable160;
						}
						subContext146.Attach((Agent)( (OperandVar161)));
					}
				}
			}
		}
        }
    }
    
    public class change_name_historical_action : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar171 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable162 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable162 != null)
			{
				Blackboards.historical_person StoredVariable163 = ((Blackboards.historical_person)StoredVariable162.GetComponent(typeof(Blackboards.historical_person))); //IsContext = False IsNew = False
				if(StoredVariable163 != null)
				{
					Named StoredVariable164 = ((Named)StoredVariable163.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable164 != null)
					{
						Agent StoredVariable165 = ((Agent)StoredVariable164.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable165 != null)
						{
							System.Boolean ifResult166; //IsContext = False IsNew = False
							
							
							System.Boolean OperandVar168 = default(System.Boolean); //IsContext = False IsNew = False
							System.Boolean prop167 = StoredVariable165.Act; //IsContext = False IsNew = False
							OperandVar168 = prop167;
							
							
							
							System.Boolean OperandVar170 = default(System.Boolean); //IsContext = False IsNew = False
							if(StoredVariable162 != null)
							{
								System.Boolean prop169 = StoredVariable162.Dead; //IsContext = False IsNew = False
								OperandVar170 = prop169;
							}
							if(ifResult166 = ( (( ( (OperandVar168))) == ( ( (true))))) && ( (!(OperandVar170))))
							{
								applicable = true;
								OperandVar171 = applicable;
							}
						}
					}
				}
			}
			return (System.Boolean) (OperandVar171);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.5f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext172 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext172 ContextSwitchInterpreter
				if(subContext172 != null)
				{
					
					System.String OperandVar175 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar173 = default(System.String); //IsContext = False IsNew = False
					OperandVar173 = "human_name";
					System.String prop174 = External.RandomName( (OperandVar173)); //IsContext = False IsNew = False
					if(prop174 != null)
					{
						OperandVar175 = prop174;
					}
					subContext172.Switch(( ("main_name")).ToString(),( (OperandVar175)).ToString());
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar181 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable176 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable176 != null)
			{
				Named StoredVariable177 = ((Named)StoredVariable176.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable177 != null)
				{
					System.Boolean ifResult178; //IsContext = False IsNew = False
					
					System.Boolean OperandVar180 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable176 != null)
					{
						System.Boolean prop179 = StoredVariable176.Act; //IsContext = False IsNew = False
						OperandVar180 = prop179;
					}
					
					
					if(ifResult178 = ( ( (OperandVar180))) == ( ( (true))))
					{
						applicable = true;
						OperandVar181 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar181);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar185 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable182 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable182 != null)
			{
				System.String OperandVar183 = default(System.String); //IsContext = False IsNew = False
				OperandVar183 = "main_name";
				System.String prop184 = StoredVariable182.Get( (OperandVar183)); //IsContext = False IsNew = False
				if(prop184 != null)
				{
					OperandVar185 = prop184;
				}
			}
			External.Log((System.Object)( (OperandVar185)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar193 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable186 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable186 != null)
			{
				Agent StoredVariable187 = ((Agent)StoredVariable186.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable187 != null)
				{
					System.Boolean ifResult188; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar190 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop189 = StoredVariable187.Act; //IsContext = False IsNew = False
					OperandVar190 = prop189;
					
					
					
					System.Boolean OperandVar192 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable186 != null)
					{
						System.Boolean prop191 = StoredVariable186.Dead; //IsContext = False IsNew = False
						OperandVar192 = prop191;
					}
					if(ifResult188 = ( (( ( (OperandVar190))) == ( ( (true))))) && ( (!(OperandVar192))))
					{
						applicable = true;
						OperandVar193 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar193);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar194 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar194 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar194)))));
			UnityEngine.GameObject OperandVar195 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar195 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar195)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar204 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable196 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable196 != null)
			{
				System.Boolean ifResult197; //IsContext = False IsNew = False
				
				System.Boolean OperandVar200 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar198 = default(System.String); //IsContext = False IsNew = False
				OperandVar198 = "init_node";
				System.Boolean prop199 = StoredVariable196.HasMarker( (OperandVar198)); //IsContext = False IsNew = False
				OperandVar200 = prop199;
				
				System.Boolean OperandVar203 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar201 = default(System.String); //IsContext = False IsNew = False
				OperandVar201 = "story_set";
				System.Boolean prop202 = StoredVariable196.HasMarker( (OperandVar201)); //IsContext = False IsNew = False
				OperandVar203 = prop202;
				if(ifResult197 = ( ( (OperandVar200))) && ( (!(OperandVar203))))
				{
					applicable = true;
					OperandVar204 = applicable;
				}
			}
			return (System.Boolean) (OperandVar204);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext205 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext205 ContextSwitchInterpreter
				if(subContext205 != null)
				{
					System.String OperandVar206 = default(System.String); //IsContext = False IsNew = False
					OperandVar206 = "story_set";
					subContext205.SetMarker(( (OperandVar206)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node207 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext208 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext209 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Entity AddContext210 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext211 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext212 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext212 ContextPropertySwitchInterpreter
				if(subContext212 != null)
				{
					
					{
						TaleNode subContext213 = (TaleNode)subContext212.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext213 ContextSwitchInterpreter
						if(subContext213 != null)
						{
							
							subContext213.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar223 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable214 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable214 != null)
			{
				Blackboards.story_node StoredVariable215 = ((Blackboards.story_node)StoredVariable214.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable215 != null)
				{
					TaleNode StoredVariable216 = ((TaleNode)StoredVariable215.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable216 != null)
					{
						System.Boolean ifResult217; //IsContext = False IsNew = False
						
						System.Boolean OperandVar220 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar218 = default(System.String); //IsContext = False IsNew = False
						OperandVar218 = "decomposed";
						System.Boolean prop219 = StoredVariable214.HasMarker( (OperandVar218)); //IsContext = False IsNew = False
						OperandVar220 = prop219;
						
						System.Boolean OperandVar222 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop221 = StoredVariable216.IsActive; //IsContext = False IsNew = False
						OperandVar222 = prop221;
						if(ifResult217 = ( (!(OperandVar220))) && ( ( (OperandVar222))))
						{
							applicable = true;
							OperandVar223 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar223);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext224 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext224 ContextSwitchInterpreter
				if(subContext224 != null)
				{
					System.String OperandVar225 = default(System.String); //IsContext = False IsNew = False
					OperandVar225 = "decomposed";
					subContext224.SetMarker(( (OperandVar225)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node226 = c_node; //IsContext = True IsNew = False
				Markers AddContext227 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext228 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext229 = (Entity)c_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext230 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node231 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext232 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext233 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext234 = (Entity)c_r_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext235 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext235 ContextSwitchInterpreter
					if(AddContext235 != null)
					{
						UnityEngine.GameObject OperandVar236 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar236 = c_node;
						AddContext235.Conflict = (UnityEngine.GameObject)( (OperandVar236));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node237 = r_node; //IsContext = True IsNew = False
				Markers AddContext238 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext239 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext240 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext240 ContextSwitchInterpreter
					if(AddContext240 != null)
					{
						UnityEngine.GameObject OperandVar241 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar241 = c_r_node;
						AddContext240.Resolution = (UnityEngine.GameObject)( (OperandVar241));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node242 = s_node; //IsContext = True IsNew = False
				Markers AddContext243 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext244 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				TaleNode AddContext245 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext246 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext246 ContextSwitchInterpreter
					if(AddContext246 != null)
					{
						UnityEngine.GameObject OperandVar247 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar247 = c_r_node;
						AddContext246.Cause = (UnityEngine.GameObject)( (OperandVar247));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node248 = cris_node; //IsContext = True IsNew = False
				Entity AddContext249 = (Entity)cris_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext250 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext251 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext252 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext252 ContextSwitchInterpreter
					if(AddContext252 != null)
					{
						UnityEngine.GameObject OperandVar253 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar253 = s_node;
						AddContext252.Solution = (UnityEngine.GameObject)( (OperandVar253));
						UnityEngine.GameObject OperandVar254 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar254 = r_node;
						AddContext252.Cause = (UnityEngine.GameObject)( (OperandVar254));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext255 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext255 ContextPropertySwitchInterpreter
				if(subContext255 != null)
				{
					
					{
						TaleNode subContext256 = (TaleNode)subContext255.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext256 ContextSwitchInterpreter
						if(subContext256 != null)
						{
							
							subContext256.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext257 = c_r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext257 ContextPropertySwitchInterpreter
				if(subContext257 != null)
				{
					
					{
						TaleNode subContext258 = (TaleNode)subContext257.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext258 ContextSwitchInterpreter
						if(subContext258 != null)
						{
							
							subContext258.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext259 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext259 ContextPropertySwitchInterpreter
				if(subContext259 != null)
				{
					
					{
						TaleNode subContext260 = (TaleNode)subContext259.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext260 ContextSwitchInterpreter
						if(subContext260 != null)
						{
							
							subContext260.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext261 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext261 ContextPropertySwitchInterpreter
				if(subContext261 != null)
				{
					
					{
						TaleNode subContext262 = (TaleNode)subContext261.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext262 ContextSwitchInterpreter
						if(subContext262 != null)
						{
							
							subContext262.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext263 = cris_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext263 ContextPropertySwitchInterpreter
				if(subContext263 != null)
				{
					
					{
						TaleNode subContext264 = (TaleNode)subContext263.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext264 ContextSwitchInterpreter
						if(subContext264 != null)
						{
							
							subContext264.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar274 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable265 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable265 != null)
			{
				Blackboards.conflict_node StoredVariable266 = ((Blackboards.conflict_node)StoredVariable265.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable266 != null)
				{
					TaleNode StoredVariable267 = ((TaleNode)StoredVariable266.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable267 != null)
					{
						System.Boolean ifResult268; //IsContext = False IsNew = False
						
						System.Boolean OperandVar271 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar269 = default(System.String); //IsContext = False IsNew = False
						OperandVar269 = "decomposed";
						System.Boolean prop270 = StoredVariable265.HasMarker( (OperandVar269)); //IsContext = False IsNew = False
						OperandVar271 = prop270;
						
						System.Boolean OperandVar273 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop272 = StoredVariable267.IsActive; //IsContext = False IsNew = False
						OperandVar273 = prop272;
						if(ifResult268 = ( (!(OperandVar271))) && ( ( (OperandVar273))))
						{
							applicable = true;
							OperandVar274 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar274);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node275 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext276 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Entity AddContext277 = (Entity)f_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext278 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext278 ContextSwitchInterpreter
						if(AddContext278 != null)
						{
							UnityEngine.GameObject OperandVar279 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar279 = root;
							AddContext278.Conflict = (UnityEngine.GameObject)( (OperandVar279));
						}
					}
					Markers AddContext280 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext281 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext281 ContextPropertySwitchInterpreter
					if(subContext281 != null)
					{
						
						{
							TaleNode subContext282 = (TaleNode)subContext281.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext282 ContextSwitchInterpreter
							if(subContext282 != null)
							{
								
								subContext282.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext283 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext283 ContextSwitchInterpreter
				if(subContext283 != null)
				{
					System.String OperandVar284 = default(System.String); //IsContext = False IsNew = False
					OperandVar284 = "decomposed";
					subContext283.SetMarker(( (OperandVar284)).ToString());
				}
			}
		}
        }
    }
    
    public class tale_ui_enlisting : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar291 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable285 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable285 != null)
			{
				TaleNode StoredVariable286 = ((TaleNode)StoredVariable285.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable286 != null)
				{
					System.Boolean ifResult287; //IsContext = False IsNew = False
					System.Boolean OperandVar290 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar288 = default(System.String); //IsContext = False IsNew = False
					OperandVar288 = "tale_enlisted";
					System.Boolean prop289 = StoredVariable285.HasMarker( (OperandVar288)); //IsContext = False IsNew = False
					OperandVar290 = prop289;
					if(ifResult287 = !(OperandVar290))
					{
						applicable = true;
						OperandVar291 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar291);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject ui = new UnityEngine.GameObject("ui"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ui292 = ui; //IsContext = True IsNew = False
				UiObject AddContext293 = (UiObject)ui.AddComponent(typeof(UiObject)); //IsContext = True IsNew = True
				
				{
					//ContextStatement UiObject AddContext293 ContextSwitchInterpreter
					if(AddContext293 != null)
					{
						UnityEngine.GameObject OperandVar294 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar294 = root;
						AddContext293.ShowedObject = (UnityEngine.GameObject)( (OperandVar294));
					}
				}
				TextField AddContext295 = (TextField)ui.AddComponent(typeof(TextField)); //IsContext = True IsNew = True
				
				{
					//ContextStatement TextField AddContext295 ContextSwitchInterpreter
					if(AddContext295 != null)
					{
						
						{
							UnityEngine.UI.LayoutElement subContext296 = AddContext295.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext296 ContextPropertySwitchInterpreter
							if(subContext296 != null)
							{
								
								subContext296.minHeight = (System.Single)( (20f));
							}
						}
						System.String OperandVar299 = default(System.String); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar297 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar297 = root;
						System.String prop298 = External.Stringify( (OperandVar297)); //IsContext = False IsNew = False
						if(prop298 != null)
						{
							OperandVar299 = prop298;
						}
						AddContext295.Show(( (OperandVar299)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ui);
			UnityEngine.GameObject OperandVar300 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar300 = ui;
			External.TalesUiEnlist((UnityEngine.GameObject)( (OperandVar300)));
			
			{
				Markers subContext301 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext301 ContextSwitchInterpreter
				if(subContext301 != null)
				{
					System.String OperandVar302 = default(System.String); //IsContext = False IsNew = False
					OperandVar302 = "tale_enlisted";
					subContext301.SetUiMarker(( (OperandVar302)).ToString());
				}
			}
		}
        }
    }
    
    public class faction_is_a_state : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar309 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.faction_node StoredVariable303 = ((Blackboards.faction_node)root.GetComponent(typeof(Blackboards.faction_node))); //IsContext = False IsNew = False
			if(StoredVariable303 != null)
			{
				Markers StoredVariable304 = ((Markers)StoredVariable303.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable304 != null)
				{
					System.Boolean ifResult305; //IsContext = False IsNew = False
					System.Boolean OperandVar308 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar306 = default(System.String); //IsContext = False IsNew = False
					OperandVar306 = "faction_is_a_state";
					System.Boolean prop307 = StoredVariable304.HasMarker( (OperandVar306)); //IsContext = False IsNew = False
					OperandVar308 = prop307;
					if(ifResult305 = !(OperandVar308))
					{
						applicable = true;
						OperandVar309 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar309);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.state_node>();
			Entity EntVar310 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar310 != null) EntVar310.ComponentAdded();
			
			{
				Markers subContext311 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext311 ContextSwitchInterpreter
				if(subContext311 != null)
				{
					System.String OperandVar312 = default(System.String); //IsContext = False IsNew = False
					OperandVar312 = "faction_is_a_state";
					subContext311.SetMarker(( (OperandVar312)).ToString());
				}
			}
		}
        }
    }
    
    public class state_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar319 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable313 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable313 != null)
			{
				System.Boolean ifResult314; //IsContext = False IsNew = False
				System.Boolean OperandVar318 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar316 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable315 = ((Named)StoredVariable313.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable315 != null)
				{
					OperandVar316 = StoredVariable315;
				}
				System.Boolean prop317 = External.Has( (OperandVar316)); //IsContext = False IsNew = False
				OperandVar318 = prop317;
				if(ifResult314 = !(OperandVar318))
				{
					applicable = true;
					OperandVar319 = applicable;
				}
			}
			return (System.Boolean) (OperandVar319);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar320 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar320 ContextSwitchInterpreter
				if(ContextVar320 != null)
				{
					
					
					System.String OperandVar323 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar321 = default(System.String); //IsContext = False IsNew = False
					OperandVar321 = "country_name";
					System.String prop322 = External.RandomName( (OperandVar321)); //IsContext = False IsNew = False
					if(prop322 != null)
					{
						OperandVar323 = prop322;
					}
					ContextVar320.Set(( ("main_name")).ToString(),(System.Single)( (0f)),( (OperandVar323)).ToString());
				}
			}
			Entity EntVar324 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar324 != null) EntVar324.ComponentAdded();
		}
        }
    }
    
    public class state_head : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar334 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable325 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable325 != null)
			{
				TaleNode StoredVariable326 = ((TaleNode)StoredVariable325.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable326 != null)
				{
					System.Boolean ifResult327; //IsContext = False IsNew = False
					
					System.Boolean OperandVar331 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar329 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable325 != null)
					{
						UnityEngine.GameObject prop328 = StoredVariable325.Head; //IsContext = False IsNew = False
						if(prop328 != null)
						{
							OperandVar329 = prop328;
						}
					}
					System.Boolean prop330 = External.Has( (OperandVar329)); //IsContext = False IsNew = False
					OperandVar331 = prop330;
					
					System.Boolean OperandVar333 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop332 = StoredVariable326.IsActive; //IsContext = False IsNew = False
					OperandVar333 = prop332;
					if(ifResult327 = ( (!(OperandVar331))) && ( ( (OperandVar333))))
					{
						applicable = true;
						OperandVar334 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar334);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.state_node subContext335 = (Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.state_node subContext335 ContextSwitchInterpreter
				if(subContext335 != null)
				{
					UnityEngine.GameObject head_of_state = new UnityEngine.GameObject("head_of_state"); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject head_of_state336 = head_of_state; //IsContext = True IsNew = False
						Markers AddContext337 = (Markers)head_of_state.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
						Blackboards.person_node AddContext338 = (Blackboards.person_node)head_of_state.AddComponent(typeof(Blackboards.person_node)); //IsContext = True IsNew = True
						TaleNode AddContext339 = (TaleNode)head_of_state.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
						Blackboards.head_of_state_node AddContext340 = (Blackboards.head_of_state_node)head_of_state.AddComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Blackboards.head_of_state_node AddContext340 ContextSwitchInterpreter
							if(AddContext340 != null)
							{
								UnityEngine.GameObject OperandVar341 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar341 = root;
								AddContext340.State = (UnityEngine.GameObject)( (OperandVar341));
							}
						}
						Entity AddContext342 = (Entity)head_of_state.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					}
					UnityEngine.Object.FindObjectOfType<Generators>().Generate(head_of_state);
					
					{
						UnityEngine.GameObject subContext343 = head_of_state; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext343 ContextPropertySwitchInterpreter
						if(subContext343 != null)
						{
							
							{
								TaleNode subContext344 = (TaleNode)subContext343.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
								//ContextStatement TaleNode subContext344 ContextSwitchInterpreter
								if(subContext344 != null)
								{
									
									subContext344.IsActive = (System.Boolean)( (true));
								}
							}
						}
					}
					UnityEngine.GameObject OperandVar345 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar345 = head_of_state;
					subContext335.Head = (UnityEngine.GameObject)( (OperandVar345));
				}
			}
		}
        }
    }
    
    public class state_head_death : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar360 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable346 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable346 != null)
			{
				Markers StoredVariable347 = ((Markers)StoredVariable346.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable347 != null)
				{
					EntityDeathEvent StoredVariable348 = ((EntityDeathEvent)StoredVariable347.GetComponent(typeof(EntityDeathEvent))); //IsContext = False IsNew = False
					if(StoredVariable348 != null)
					{
						System.Boolean ifResult349; //IsContext = False IsNew = False
						
						System.Boolean OperandVar356 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable346 != null)
						{
							UnityEngine.GameObject prop350 = StoredVariable346.Context; //IsContext = False IsNew = False
							if(prop350 != null)
							{
								System.Boolean ifResult351; //IsContext = False IsNew = False
								System.Boolean OperandVar355 = default(System.Boolean); //IsContext = False IsNew = False
								Blackboards.head_of_state_node OperandVar353 = default(Blackboards.head_of_state_node); //IsContext = False IsNew = False
								Blackboards.head_of_state_node StoredVariable352 = ((Blackboards.head_of_state_node)prop350.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
								if(StoredVariable352 != null)
								{
									OperandVar353 = StoredVariable352;
								}
								System.Boolean prop354 = External.Has( (OperandVar353)); //IsContext = False IsNew = False
								OperandVar355 = prop354;
								if(ifResult351 =  (OperandVar355))
								{
									OperandVar356 = ifResult351;
								}
							}
						}
						
						System.Boolean OperandVar359 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar357 = default(System.String); //IsContext = False IsNew = False
						OperandVar357 = "state_head_death_reacted";
						System.Boolean prop358 = StoredVariable347.HasMarker( (OperandVar357)); //IsContext = False IsNew = False
						OperandVar359 = prop358;
						if(ifResult349 = ( ( (OperandVar356))) && ( (!(OperandVar359))))
						{
							applicable = true;
							OperandVar360 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar360);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext361 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext361 ContextSwitchInterpreter
				if(subContext361 != null)
				{
					System.String OperandVar362 = default(System.String); //IsContext = False IsNew = False
					OperandVar362 = "state_head_death_reacted";
					subContext361.SetMarker(( (OperandVar362)).ToString());
				}
			}
			
			{
				Event subContext363 = (Event)root.GetComponent(typeof(Event)); //IsContext = True IsNew = False
				//ContextStatement Event subContext363 ContextSwitchInterpreter
				if(subContext363 != null)
				{
					
					{
						UnityEngine.GameObject subContext364 = subContext363.Context; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext364 ContextPropertySwitchInterpreter
						if(subContext364 != null)
						{
							
							{
								Blackboards.head_of_state_node subContext365 = (Blackboards.head_of_state_node)subContext364.GetComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.head_of_state_node subContext365 ContextSwitchInterpreter
								if(subContext365 != null)
								{
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class state_head_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar372 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.head_of_state_node StoredVariable366 = ((Blackboards.head_of_state_node)root.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
			if(StoredVariable366 != null)
			{
				System.Boolean ifResult367; //IsContext = False IsNew = False
				System.Boolean OperandVar371 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar369 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable368 = ((Named)StoredVariable366.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable368 != null)
				{
					OperandVar369 = StoredVariable368;
				}
				System.Boolean prop370 = External.Has( (OperandVar369)); //IsContext = False IsNew = False
				OperandVar371 = prop370;
				if(ifResult367 = !(OperandVar371))
				{
					applicable = true;
					OperandVar372 = applicable;
				}
			}
			return (System.Boolean) (OperandVar372);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar373 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar373 ContextSwitchInterpreter
				if(ContextVar373 != null)
				{
					System.String OperandVar374 = default(System.String); //IsContext = False IsNew = False
					OperandVar374 = "main_name";
					
					System.String OperandVar377 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar375 = default(System.String); //IsContext = False IsNew = False
					OperandVar375 = "human_name";
					System.String prop376 = External.RandomName( (OperandVar375)); //IsContext = False IsNew = False
					if(prop376 != null)
					{
						OperandVar377 = prop376;
					}
					ContextVar373.Set(( (OperandVar374)).ToString(),(System.Single)( (0f)),( (OperandVar377)).ToString());
				}
			}
			Entity EntVar378 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar378 != null) EntVar378.ComponentAdded();
		}
        }
    }
}
